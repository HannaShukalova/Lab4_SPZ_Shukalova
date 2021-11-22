namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
        private Random rand = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            string filename = saveFileDialog1.FileName;
            createFile(filename);
        }
        private void createFile(string adress)
        {
            StreamWriter sr = new StreamWriter(adress);
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 100);
                sr.Write(array[i] + " ");
            }
            file1.Text = String.Join(",", array.Select(p => p.ToString()).ToArray());
            sr.Close();
        }

        private void writeFile(string adress, int[] array)
        {
            StreamWriter sr = new StreamWriter(adress);
            for (int i = 0; i < array.Length; i++)
            {
                sr.Write(array[i] + " ");
            }
            sr.Close();
        }

        private int[] readFile(string adress) { 
            StreamReader sr = new StreamReader(adress);
            string resultStr = sr.ReadToEnd().Trim();
            string[] arrayStr = resultStr.Split(delimiterChars);
            int[] arrayInt = arrayStr.Select(int.Parse).ToArray();
            return arrayInt;
        }

        private int minElement(int[] array)
        {
            int minElement = 100;
            int index = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                   if(minElement > array[j])
                    {
                       minElement = array[i];
                       index = i;
                    }
                }
            }
            return index;
        }

        private int maxElement(int[] array)
        {
            int maxElement = 0;
            int index = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (maxElement < array[j])
                    {
                        maxElement = array[i];
                        index = i;
                    }
                }
            }
            return index;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            string filenameOpen = openFileDialog1.FileName;

            int[] array = readFile(filenameOpen);
            int maxIndex = maxElement(array);
            int minIndex = minElement(array);

            int maxElementNum = array[maxIndex];
            int minElementNum = array[minIndex];

            array[minIndex] = maxElementNum;
            array[maxIndex] = minElementNum;

            file2.Text = String.Join(",", array.Select(p => p.ToString()).ToArray());

            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            string filenameSave = saveFileDialog1.FileName;

            writeFile(filenameSave, array);
        }
    }
}