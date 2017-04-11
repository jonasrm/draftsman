using Desenhista.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desenhista
{
    public partial class MDI : Form
    {
        public enum Etapa
        {
            GerarPopulacaoInicial,
            Avaliar,
            SelecaoNatural,
            CrossOver,
            Mutacao,
            ProximaGeracao
        }

        public bool executar = false;
        public Etapa etapa = Etapa.GerarPopulacaoInicial;
        public Population population;
        private DateTime dateTime = new DateTime();

        public MDI()
        {
            InitializeComponent();
        }

        private void btnSelecionarOrigem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Selecionar Imagem de Origem";
                dlg.Filter = "Arquivos de Imaegm |*.bmp;*.jpg;*.gif;*.png";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    Rectangle cropRect = new Rectangle(0, 0, picOrigem.Width, picOrigem.Height);
                    Bitmap src = new Bitmap(dlg.FileName);
                    Bitmap target = new Bitmap(picOrigem.Width, picOrigem.Height);

                    using (Graphics g = Graphics.FromImage(target))
                        g.DrawImage(src, new Rectangle(0, 0, target.Width, target.Height), cropRect, GraphicsUnit.Pixel);

                    picOrigem.Image = target;
                    picThreshold.Image = Tools.GetResize(target, 16, 16);
                    //picThreshold.Image = Tools.GetThreshold(target, 16, 16);

                    Tools.imageTarget = target;
                    Tools.imageTargetReduced = Tools.GetResize(Tools.imageTarget, 16, 16);
                    Tools.imageTargetThreshold = Tools.GetThreshold(Tools.imageTarget, 16, 16);
                    Tools.imageTargetHash = Tools.GetHash(target);
                }
            }
        }



        private void btnIniciar_Click(object sender, EventArgs e)
        {
            etapa = Etapa.GerarPopulacaoInicial;

            //preset
            switch (cmbAvaliacao.SelectedIndex)
            {
                case 0:
                    Tools.typeAvaliation = Tools.TypeAvaliation.originalImage;
                    break;
                case 1:
                    Tools.typeAvaliation = Tools.TypeAvaliation.reducedImage;
                    break;
                case 2:
                    Tools.typeAvaliation = Tools.TypeAvaliation.byPixelOriginalImage;
                    break;
                case 3:
                    Tools.typeAvaliation = Tools.TypeAvaliation.byPixelReducedImage;
                    break;
            }

            switch (cmbSelecao.SelectedIndex)
            {
                case 0:
                    Tools.typeNaturalSelection = Tools.TypeNaturalSelection.elitist;
                    break;
                case 1:
                    Tools.typeNaturalSelection = Tools.TypeNaturalSelection.half;
                    break;
            }

            switch (cmbForma.SelectedIndex)
            {
                case 0:
                    Tools.typeForm = Tools.TypeForm.ellipse;
                    Tools.maxDiameter = picResultado.Width;
                    Tools.maxDNA = 500;
                    Tools.addDNA = 1;
                    break;
                case 1:
                    Tools.typeForm = Tools.TypeForm.square;
                    Tools.maxDiameter = picResultado.Width;
                    Tools.maxDNA = 500;
                    Tools.addDNA = 1;
                    break;
                case 2:
                    Tools.typeForm = Tools.TypeForm.dot;
                    Tools.maxDiameter = 10;
                    Tools.maxDNA = 1000;
                    Tools.addDNA = 10;
                    break;
            }

            Tools.population = (int)txtPopulacao.Value;
            Tools.mutation = (int)txtMutacao.Value;
            Tools.generation = (int)txtGeracoes.Value;
            Tools.maxWidth = picResultado.Width;
            Tools.maxHeight = picResultado.Height;
            Tools.countDNA = 1;

            progressBar.Maximum = (int)txtGeracoes.Value;
            progressBar.Value = 0;

            population = new Population();
            lblGeracao.Text = population.generation.ToString();
            lblEtapa.Text = "Iniciado";

            btnProximaEtapa.Enabled = true;
            btnTodasEtapas.Enabled = true;
            btnParar.Enabled = true;
        }

        private void Logar(string mensagem)
        {
            lblEtapa.Text = mensagem;
            this.Refresh();
        }

        /// <summary>
        /// Exibir imagens
        /// </summary>
        /// <param name="somenteMelhor"></param>
        private void AtualizarTela()
        {
            var best = population.GetPopulation()[0];
            var last = population.GetPopulation().Count;

           picResultado.Image = best.GetImage();
            picBestThreshold.Image = best.GetImagemReduced();
            p1.Image = population.GetPopulation()[1].GetImage();
            p2.Image = population.GetPopulation()[2].GetImage();
            p3.Image = population.GetPopulation()[3].GetImage();
            p4.Image = population.GetPopulation()[last - 2].GetImage();
            p5.Image = population.GetPopulation()[last - 1].GetImage();

            lblFitness.Text = best.fitness.ToString();
            lblDNA.Text = best.DNA.Count.ToString();

            progressBar.Value = population.generation;
            lblGeracao.Text = population.generation.ToString();
            lblEtapa.Text = (DateTime.Now - dateTime).ToString();

            this.Refresh();
        }


        /// <summary>
        /// Exibir etapa
        /// </summary>
        private void ProximaEtapa()
        {

            if (population.generation >= (int)txtGeracoes.Value)
            {
                Logar("Critério de parada alcançado!");
                btnProximaEtapa.Enabled = false;
                btnTodasEtapas.Enabled = false;
                btnParar.Enabled = false;
            }

            Application.DoEvents();
            switch (etapa)
            {
                case Etapa.GerarPopulacaoInicial:
                    population.GenerateStartPopulation();
                    AtualizarTela();

                    etapa = Etapa.Avaliar;
                    break;
                case Etapa.Avaliar:
                    population.ToEvaluate();

                    etapa = Etapa.SelecaoNatural;
                    break;
                case Etapa.SelecaoNatural:
                    population.NaturalSelection();
                    
                    etapa = Etapa.CrossOver;
                    break;
                case Etapa.CrossOver:
                    population.CrossOver();
                    
                    etapa = Etapa.Mutacao;
                    break;
                case Etapa.Mutacao:
                    population.Mutation();
                    
                    etapa = Etapa.ProximaGeracao;
                    break;
                case Etapa.ProximaGeracao:
                    population.NextGeneration();
                    
                    etapa = Etapa.Avaliar;
                    break;
            }
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            txtGeracoes.Value = 10000;
            txtPopulacao.Value = 100;
            txtMutacao.Value = 10;

            cmbAvaliacao.Items.Add("Bytes Original");
            cmbAvaliacao.Items.Add("Bytes Reduzida");
            cmbAvaliacao.Items.Add("Pixel Original");
            cmbAvaliacao.Items.Add("Pixel Reduzida");
            cmbAvaliacao.SelectedIndex = 3;

            cmbSelecao.Items.Add("Elitista");
            cmbSelecao.Items.Add("Metade");
            cmbSelecao.SelectedIndex = 1;

            cmbForma.Items.Add("Círculo");
            cmbForma.Items.Add("Quadrado");
            cmbForma.Items.Add("Ponto");
            cmbForma.SelectedIndex = 0;

        }

        private void btnProximaEtapa_Click(object sender, EventArgs e)
        {
            ProximaEtapa();
        }

        private void btnTodasEtapas_Click(object sender, EventArgs e)
        {
            dateTime = DateTime.Now;
            executar = true;
            while (population.generation < Tools.generation && executar)
            {
                ProximaEtapa();
                AtualizarTela();
            }
                
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            executar = false;
        }
    }
}
