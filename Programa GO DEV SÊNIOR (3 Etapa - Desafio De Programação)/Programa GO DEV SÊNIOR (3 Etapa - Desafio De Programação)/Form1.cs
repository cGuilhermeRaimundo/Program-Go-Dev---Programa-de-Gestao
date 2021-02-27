using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_GO_DEV_SÊNIOR__3_Etapa___Desafio_De_Programação_
{
    public partial class Form1 : Form
    {
        // Formulário Todos2;
        List<string> ListPessoas;
        List<string> ListSalas;
        List<string> ListCafes;
        List<string> ComboBox;
        List<string> ListaCafes;
        List<int> ListLotSalas;
        List<int> ListLotCafes;
        List<string> SalasE1;
        List<string> SalasE2;

        public int Id_Select { get; set; }
        public string Selecionado { get; set; }
        public Form1()
        {
            InitializeComponent();
            ListPessoas = new List<string>();
            ListSalas = new List<string>();
            ListCafes = new List<string>();
            ComboBox = new List<string>();
            ListaCafes = new List<string>();
            ListLotSalas = new List<int>();
            ListLotCafes = new List<int>();
            SalasE1 = new List<string>();
            SalasE2 = new List<string>();
        }
        public void Form1_Load(object sender, EventArgs e)
        {

        }

        // Cadastro de Pessoas
        public void txt_Nome_Pessoa_TextChanged(object sender, EventArgs e)
        {

        }
        public void txt_Sobrenome_Pessoa_TextChanged(object sender, EventArgs e)
        {

        }
        public void botao_Cadastrar_Pessoa_Click(object sender, EventArgs e)
        {
            if (txt_Nome_Pessoa.Text == "")
            {   // Campo Nome foi preenchido?
                MessageBox.Show("Preencha o Nome da Pessoa.");
                txt_Nome_Pessoa.Focus();
                return;
            }
            else if (txt_Sobrenome_Pessoa.Text == "")
            {   // Campo Sobrenome foi preenchido?
                MessageBox.Show("Preencha o Sobrenome da Pessoa.");
                txt_Sobrenome_Pessoa.Focus();
                return;
            }
            else
            {   // Cadastro e Consulta de Nome & Sobrenome das Pessoas
                ListPessoas.Add(txt_Nome_Pessoa.Text + " " + txt_Sobrenome_Pessoa.Text);
                txt_Nome_Pessoa.Text = "";
                txt_Sobrenome_Pessoa.Text = "";

                // Lista Nomes
                list_Nome_Pessoa.Items.Clear();
                for (int i = 0; i < ListPessoas.Count; i++)
                {
                    list_Nome_Pessoa.Items.Add(ListPessoas[i]);
                }
            }
        }

        // Cadastro de Salas do Evento
        public void txt_Nome_Sala_TextChanged(object sender, EventArgs e)
        {

        }
        public void num_Lot_Sala_ValueChanged(object sender, EventArgs e)
        {

        }
        public void botao_Cadastrar_Sala_Click(object sender, EventArgs e)
        {
            if (ListPessoas.Count <= 0)
            {   // Possui alguma pessoa cadastrada?
                MessageBox.Show("Cadastre as Pessoas primeiro.");
                txt_Nome_Pessoa.Focus();
                return;
            }
            else if (txt_Nome_Sala.Text == "")
            {   // Campo Nome foi preenchido?
                MessageBox.Show("Preencha o Nome da Sala.");
                txt_Nome_Sala.Focus();
                return;
            }
            else if (num_Lot_Sala.Value <= 0)
            {   // Campo Lotação Máxima foi prenchido?
                MessageBox.Show("Preencha a Lotação Máxima com um valor acima de 0.");
                num_Lot_Sala.Focus();
                return;
            }
            else
            {   // Cadastro e Consulta das Salas do Evento
                ListSalas.Add(txt_Nome_Sala.Text);
                ListLotSalas.Add((int)num_Lot_Sala.Value);
                ComboBox.Add(txt_Nome_Sala.Text);
                txt_Nome_Sala.Text = "";
                num_Lot_Sala.Value = 0;

                // Lista Salas Etapa 1
                list_SalaE1.Items.Clear();
                SalasE1.Clear();
                for (int i = 0; i < ListSalas.Count; i++)
                {
                    for (int j = 0; j < ListLotSalas[i]; j++)
                    {
                        list_SalaE1.Items.Add(ListSalas[i]);
                        SalasE1.Add(ListSalas[i]);

                    }
                }


                // Lista Salas Etapa 2
                list_SalaE2.Items.Clear();
                SalasE2.Clear();
                for (int i = 0; i < ListSalas.Count; i++)
                {
                    if (ListLotSalas[i] % 2 == 0)
                    {
                        for (int j = 0; j < (ListLotSalas[i] / 2); j++)
                        {
                            list_SalaE2.Items.Add(ListSalas[i]);
                            SalasE2.Add(ListSalas[i]);
                        }
                        for (int j = 0; j < (ListLotSalas[i] / 2); j++)
                        {
                            list_SalaE2.Items.Add(ListSalas[(ListSalas.Count - 1) - i]);
                            SalasE2.Add(ListSalas[(ListSalas.Count - 1) - i]);
                        }
                    }
                    else
                    {
                        for (int j = 0; j < (((ListLotSalas[i] - 1) / 2) + 1); j++)
                        {
                            list_SalaE2.Items.Add(ListSalas[i]);
                            SalasE2.Add(ListSalas[i]);
                        }
                        for (int j = 0; j < ((ListLotSalas[i] - 1) / 2); j++)
                        {
                            list_SalaE2.Items.Add(ListSalas[(ListSalas.Count - 1) - i]);
                            SalasE2.Add(ListSalas[(ListSalas.Count - 1) - i]);
                        }
                    }
                }
            }

            comboBox_NomeSE.Items.Clear();
            for (int i = 0; i < ComboBox.Count; i++)
            {
                comboBox_NomeSE.Items.Add(ComboBox[i]);
            }
        }

        // Cadastro de Espaços de Café
        public void txt_Nome_Cafe1_TextChanged(object sender, EventArgs e)
        {

        }
        public void num_Lot_Cafe1_ValueChanged(object sender, EventArgs e)
        {

        }
        public void txt_Nome_Cafe2_TextChanged(object sender, EventArgs e)
        {

        }
        public void num_Lot_Cafe2_ValueChanged(object sender, EventArgs e)
        {

        }
        public void botao_Cadastrar_Cafe_Click(object sender, EventArgs e)
        {
            if (ListPessoas.Count <= 0)
            {   // Possui alguma pessoa cadastrada?
                MessageBox.Show("Cadastre as Pessoas primeiro.");
                txt_Nome_Pessoa.Focus();
                return;
            }
            else if (ListSalas.Count <= 0)
            {   // Possui alguma sala cadastrada?
                MessageBox.Show("Cadastre as salas primeiro.");
                txt_Nome_Sala.Focus();
                return;
            }
            else if (txt_Nome_Cafe1.Text == "")
            {   // O campo Nome foi preenchido? (Cantina1)
                MessageBox.Show("Preencha o Nome do 1º Espaço de Café."); ;
                txt_Nome_Cafe1.Focus();
                return;
            }
            else if (num_Lot_Cafe1.Value <= 0)
            {   // O campo Lotação Máxima foi prenchido? (Cantina1)
                MessageBox.Show("Preencha a Lotação Máxima com um valor acima de 0.");
                num_Lot_Cafe1.Focus();
                return;
            }
            else if (txt_Nome_Cafe2.Text == "")
            {   // o Campo Nome foi preenchido? (Cantina2)
                MessageBox.Show("Preencha o Nome do 2º Espaço de Café."); ;
                txt_Nome_Cafe2.Focus();
                return;
            }
            else if (num_Lot_Cafe2.Value <= 0)
            {   // o campo Lotação Máxima foi preenchido? (Cantina2)
                MessageBox.Show("Preencha a Lotação Máxima com um valor acima de 0.");
                num_Lot_Cafe2.Focus();
                return;
            }
            else
            {   // Cadastro e Consulta das Cantinas
                ListCafes.Add(txt_Nome_Cafe1.Text);
                ListCafes.Add(txt_Nome_Cafe2.Text);
                ListLotCafes.Add((int)num_Lot_Cafe1.Value);
                ListLotCafes.Add((int)num_Lot_Cafe2.Value);
                txt_Nome_Cafe1.Text = "";
                txt_Nome_Cafe2.Text = "";
                num_Lot_Cafe1.Value = 0;
                num_Lot_Cafe2.Value = 0;
                for (int i = 0; i < 2; i++)
                {
                    ComboBox.Add(ListCafes[i]);
                }

                // Lista Cantinas Da Primeira & Segunda Etapa
                list_CafeE1.Items.Clear();
                ListaCafes.Clear();
                for (int i = 0; i < ListCafes.Count; i++)
                {
                    for (int j = 0; j < ListLotCafes[i]; j++)
                    {
                        list_CafeE1.Items.Add(ListCafes[i]);
                        list_CafeE2.Items.Add(ListCafes[i]);
                        ListaCafes.Add(ListCafes[i]);
                    }
                }
            }
            comboBox_NomeSE.Items.Clear();
            for (int i = 0; i < ComboBox.Count; i++)
            {
                comboBox_NomeSE.Items.Add(ComboBox[i]);
            }
        }
        // Consultas
        public void Consultas(object sender, EventArgs e)
        {
        }
        public void list_Nome_Pessoa_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        public void list_SalaE1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        public void list_CafeE1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void list_CafeE2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void list_SalaE2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void comboBox_NomeSE_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_NomeSE.Text == ComboBox[ComboBox.Count -1])
            {
                list_Etapa1.Items.Clear();
                list_Etapa2.Items.Clear();
                for (int i = 0; i < ListaCafes.Count; i++)
                {
                    if (ListaCafes[i] == comboBox_NomeSE.Text)
                    {
                        list_Etapa1.Items.Add(ListPessoas[i]);
                        list_Etapa2.Items.Add(ListPessoas[i]);
                    }
                }
            }
            else if (comboBox_NomeSE.Text == ComboBox[ComboBox.Count - 2])
            {
                list_Etapa1.Items.Clear();
                list_Etapa2.Items.Clear();
                for (int i = 0; i < ListaCafes.Count; i++)
                {
                    if (ListaCafes[i] == comboBox_NomeSE.Text)
                    {
                        list_Etapa1.Items.Add(ListPessoas[i]);
                        list_Etapa2.Items.Add(ListPessoas[i]);
                    }
                }
            }
            else
            {
                list_Etapa1.Items.Clear();
                for (int i = 0; i < SalasE1.Count; i++)
                {
                    if (SalasE1[i] == comboBox_NomeSE.Text)
                    {
                        list_Etapa1.Items.Add(ListPessoas[i]);
                    }
                }

                list_Etapa2.Items.Clear();
                for (int i = 0; i < SalasE2.Count; i++)
                {
                    if (SalasE2[i] == comboBox_NomeSE.Text)
                    {
                        list_Etapa2.Items.Add(ListPessoas[i]);
                    }
                }
            }
        }
        public void list_Etapa1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void list_Etapa2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
