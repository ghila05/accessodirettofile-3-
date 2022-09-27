using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace accessodirettofile_2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string filename = "veneto_verona.csv";
        private void button1_Click(object sender, EventArgs e)
        {
            string cerca = textBox1_ingresso.Text.ToUpper();

            Ricerca(filename, cerca);

            

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        static string Ricerca(string filename, string nomecercato)
        {
            string line="";
            var f = new FileStream(filename, FileMode.Open, FileAccess.ReadWrite);// accesso al file binario 
            BinaryReader reader = new BinaryReader(f);
            BinaryWriter writer = new BinaryWriter(f);


            int righetot = Convert.ToInt32(f.Length);
           
           // f.Position = (righetot);
            //line += Encoding.ASCII.GetString(reader.ReadBytes(528));
            //line = FromString(line);


            int lunghezzariga = 528;
            righetot = righetot / 528;

            

           


            int lung =Convert.ToInt32(f.Length);
            int i = 0, j = righetot - 1, m, pos = -1;

            do
            {
                m = (i + j) / 2;
                f.Seek(m * lunghezzariga, SeekOrigin.Begin);
                line += Encoding.ASCII.GetString(reader.ReadBytes(lunghezzariga));
                line = FromString(line);

                if (line == nomecercato)
                {
                    pos = m;
                }
                else if (myCompare(line, nomecercato) == -1)
                {
                    i = m + 1;
                }
                else
                    j = m - 1;
               

            } while (i <= j && pos == -1);

            if (pos != -1)
                MessageBox.Show("campo trovato in posizione: " + pos);
            else
                MessageBox.Show("campo non trovato");







            MessageBox.Show(line);
            f.Close();
            return line;
           
        }

        static int myCompare(string stringa1, string stringa2) // gentilmente presa da Marco Borelli
        {
            if (stringa1 == stringa2)//0=sono uguali 1=stringa viene prima -1=stringa viene dopo
                return 0;

            char[] char1 = stringa1.ToCharArray();
            char[] char2 = stringa2.ToCharArray();
            int l = char1.Length;
            if (char2.Length < l)//in l c'è la lunghezza più piccola
                l = char2.Length;

            for (int i = 0; i < l; i++)
            {
                if (char1[i] < char2[i])
                    return -1;
                if (char1[i] > char2[i])
                    return 1;
            }

            return 0;//visto che qui non mi interessa lunghezza allora mi basta che la prima parte si uguale
        }



        public static string FromString(string Stringa, string sep = ";", int pos = 0)//funzione che da una stringa separa i campi e ritorna una stringa
        {
            string[] ris = Stringa.Split(';');
            return ris[pos];
            
        }
    }
}
