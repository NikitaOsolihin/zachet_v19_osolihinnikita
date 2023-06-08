namespace zachet_v19_FI2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // ������ ����� �� �������� �����
            double[] numbers = File.ReadAllLines("input.txt")
            .Select(double.Parse)
            .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                listBox1.Items.Add(numbers[i]);
            }

            StreamWriter sw = File.CreateText("output.txt");

            //���������� ��� ������������� �����
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                {
                    sw.WriteLine(numbers[i]);
                    listBox2.Items.Add(numbers[i]);
                }

            }

            //���������� ��� ������������� �����
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    sw.WriteLine(numbers[i]);
                    listBox2.Items.Add(numbers[i]);
                }

            }

            //���������� ��� ������� �����
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 0)
                {
                    sw.WriteLine(numbers[i]);
                    listBox2.Items.Add(numbers[i]);
                }

            }
            sw.Close();




        }
    }
}