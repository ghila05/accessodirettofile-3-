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
            string cerca = textBox1_ingresso.Text;


            Ricerca(filename, cerca);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        static string Ricerca(string filename, string nomecercato)
        {
            string line="";
            var f = new FileStream(filename, FileMode.Open, FileAccess.ReadWrite);
            BinaryReader reader = new BinaryReader(f);
            BinaryWriter writer = new BinaryWriter(f);


            int ciao = Convert.ToInt32(f.Length);
            ciao = ciao / 528;
            line += Encoding.ASCII.GetString(reader.ReadBytes(528));
            MessageBox.Show(Convert.ToString(ciao));//righe totali 
            MessageBox.Show(line);



            return "ciao";
        }
        static int binarySearch(int[] arr, int sx, int rx, int x)
        {
            if (rx >= sx)
            {
                int mid = sx + (rx - sx) / 2;

                if (arr[mid] == x)
                {
                    return mid;
                }

                if (arr[mid] > x)
                {
                    return binarySearch(arr, sx, mid - 1, x);
                }

                return binarySearch(arr, mid + 1, rx, x);
            }

            return -1;
        }


        static void StringSplit(string line)
        {
            string separatore = ";";

            line.Split(separatore);

        }

        public static string FromString(string votoStringa, string sep = ";")//funzione che da una stringa separa i campi e ritorna una struct associata a i campi di essa
        {
            string[] ris = votoStringa.Split(';');

            return ris[8];
            
            
        }
    }
}
