using System;
using System.Windows.Forms;

namespace Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            groupBoxSign.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Convert_Back_End();
        }

        int neg=0;

        public void Convert_Back_End()
        {
            int operation=0;
            if (Add.Checked)
            {
                operation = 1;
            }
            else if (Sub.Checked)
                operation = 2;
            else
                MessageBox.Show("Please choose an operation", "Error!");
            int format = 0;
            if (InDec.Checked) format = 1;
            else if (InBin.Checked) format = 2;
            else if (InOct.Checked) format = 3;
            else if (InHex.Checked) format = 4;
            else
                MessageBox.Show("Please choose an Input Type", "Error!");

            int oformat = 0;
            if (OutDec.Checked) oformat = 1;
            else if (OutBin.Checked) oformat = 2;
            else if (OutOct.Checked) oformat = 3;
            else if (OutHex.Checked) oformat = 4;
            else
                MessageBox.Show("Please choose an Input Type", "Error!");

            int type = 0;
            if (Sign.Checked) type = 1;
            else if (Unsign.Checked) type = 2;

            string binary1 = "", binary2 = "";
            int a=0, b=0;

            binary1 = Number1.Text;
            binary2 = Number2.Text;

            switch (format)
            {
                case 1:
                    {
                        binary1 = D2B(binary1);
                        binary2 = D2B(binary2);
                        binary1 = uaddspace(binary1);
                        binary2 = uaddspace(binary2);
                        break;
                    }
                case 2:
                    {
                        switch (type)
                        {
                            case 1:
                                {
                                    binary1 = addspace(binary1);
                                    binary2 = addspace(binary2);

                                    if (binary1[0] == 49)
                                        binary1 = two(binary1);
                                    if (binary2[0] == 49)
                                        binary2 = two(binary2);
                                    break;
                                }

                            case 2:
                                {
                                    if (binary1[0] == 45)
                                    {

                                        binary1 = binary1.Remove(0, 1);
                                        binary1 = uaddspace(binary1);
                                        binary1 = utwo(binary1);
                                        a = -1;
                                    }
                                    else
                                    {
                                        binary1 = uaddspace(binary1);
                                    }
                                    if (binary2[0] == 45)
                                    {
                                        binary2 = binary2.Remove(0, 1);
                                        binary2 = uaddspace(binary2);
                                        binary2 = utwo(binary2);
                                        b = -1;
                                    }
                                    else
                                    {
                                        binary2 = uaddspace(binary2);
                                    }
                                    break;
                                }
                        }
                        break;
                    }
                case 3:
                    if (binary1[0] == 45)
                    {
                        binary1 = binary1.Remove(0, 1);
                        binary1 = nOctToBin(binary1);
                    }
                    else
                    {
                        binary1 = OctToBin(binary1);
                    }
                    if (binary2[0] == 45)
                    {
                        binary2 = binary1.Remove(0, 1);
                        binary2 = nOctToBin(binary2);
                    }
                    else
                    {
                        binary2 = OctToBin(binary2);
                    }
                    break;
                case 4:
                    binary1 = H2B(binary1);
                    binary2 = H2B(binary2);
                    binary1 = uaddspace(binary1);
                    binary2 = uaddspace(binary2);
                    break;

            }

            int[] A = new int[16];
            int[] B = new int[16];



            switch (operation)
            {
                case 1:
                    {
                        if (format != 2)
                        {
                            for (int i = 15; i != 0; i--)
                            {
                                int x = binary1[i];
                                int y = binary2[i];
                                A[i] = x - 48;
                                B[i] = y - 48;
                            }
                            string C = sumbinary(A, B);
                            switch (oformat)
                            {
                                case 1: C = B2D(C); break;
                                case 3: C = B2O(C); break;
                                case 4: C = B2H(C); break;
                            }
                            Output.Text = C;
                        }
                        else
                        {
                            switch (type)
                            {
                                case 1:
                                    {
                                        for (int i = 15; i >= 0; i--)
                                        {
                                            int x = binary1[i];
                                            int y = binary2[i];
                                            A[i] = x - 48;
                                            B[i] = y - 48;
                                        }
                                        string C = sumbinary(A, B);
                                        switch (oformat)
                                        {
                                            case 1: C = B2D(C); break;
                                            case 3: C = B2O(C); break;
                                            case 4: C = B2H(C); break;
                                        }
                                        Output.Text = C;
                                        break;
                                    }
                                case 2:
                                    {
                                        for (int i = 15; i >= 0; i--)
                                        {
                                            int x = binary1[i];
                                            int y = binary2[i];
                                            A[i] = x - 48;
                                            B[i] = y - 48;
                                        }
                                        string C = usumbinary(A, B, a, b);
                                        switch (oformat)
                                        {
                                            case 1: C = B2D(C); break;
                                            case 3: C = B2O(C); break;
                                            case 4: C = B2H(C); break;
                                        }
                                        if (neg == 1)
                                            Output.Text = "-" + C;
                                        else
                                            Output.Text = C;
                                        break;
                                    }
                            }
                        }

                        break;
                    }

                case 2:
                    {
                        if (format != 2)
                        {
                            if (a < 0 && b < 0)
                            {
                                binary1 = two(binary1);
                            }
                            binary2 = utwo(binary2);
                            for (int i = 15; i >= 0; i--)
                            {
                                int x = binary1[i];
                                int y = binary2[i];
                                A[i] = x - 48;
                                B[i] = y - 48;
                            }
                            string C = difbinary(A, B, 0);
                            switch (oformat)
                            {
                                case 1: C = B2D(C); break;
                                case 3: C = B2O(C); break;
                                case 4: C = B2H(C); break;
                            }
                            Output.Text = C;
                        }
                        else
                        {
                            switch (type)
                            {
                                case 1:
                                    {
                                        if (binary1[0] == 49)
                                            binary1 = two(binary1);
                                        binary2 = utwo(binary2);
                                        for (int i = 15; i >= 0; i--)
                                        {
                                            int x = binary1[i];
                                            int y = binary2[i];
                                            A[i] = x - 48;
                                            B[i] = y - 48;
                                        }
                                        string C = difbinary(A, B, 1);
                                        switch(oformat)
                                        {
                                            case 1: C = B2D(C); break;
                                            case 3: C = B2O(C); break;
                                            case 4: C = B2H(C); break;
                                        }
                                        Output.Text = C;
                                        break;
                                    }
                                case 2:
                                    {
                                        binary2 = utwo(binary2);
                                        for (int i = 15; i >= 0; i--)
                                        {
                                            int x = binary1[i];
                                            int y = binary2[i];
                                            A[i] = x - 48;
                                            B[i] = y - 48;
                                        }
                                        string C = udifbinary(A, B);
                                        switch (oformat)
                                        {
                                            case 1: C = B2D(C); break;
                                            case 3: C = B2O(C); break;
                                            case 4: C = B2H(C); break;
                                        }
                                        if (neg == 1)
                                            Output.Text = "-" + C;
                                        else
                                            Output.Text = C;
                                        break;
                                    }
                            }
                        }
                        break;
                    }
            }
        }

        string B2H(string b)
        {
            string a = Convert.ToInt32(b, 2).ToString("X");
            return a;
        }

        string B2O(string b)
        {
            int a = Convert.ToInt32(b, 2);
            string c = Convert.ToString(a, 8);
        return c;
        }

        string B2D(string b)
        {
            string a = Convert.ToInt32(b, 2).ToString();
            return a;
        }

        string sumbinary(int[] A, int[] B)
        {
            int carry = 0;
            int[] C = new int[16];
            for (int i = 0; i < 16; i++)
                C[i] = 0;
            for (int i = 15; i >= 0; i--)
            {
                int a = A[i], b = B[i];
                if (i == 0)
                {
                    switch (a + b + C[i])
                    {
                        case 0:
                            C[i] = 0;
                            carry = 0;
                            break;

                        case 1:
                            C[i] = 1;
                            carry = 0;
                            break;

                        case 2:
                            C[i] = 0;
                            carry = 1;
                            break;

                        case 3:
                            C[i] = 1;
                            carry = 1;
                            break;
                    }
                }
                else if (a + b + C[i] == 3)
                {
                    C[i] = 1;
                    C[i - 1] = 1;
                }
                else if (a + b + C[i] == 2)
                {
                    C[i] = 0;
                    C[i - 1] = 1;
                }
                else if (A[i] + B[i] + C[i] == 1)
                {
                    C[i] = 1;
                    C[i - 1] = 0;
                }
                else if (a + b + C[i] == 0)
                {
                    C[i] = 0;
                    C[i - 1] = 0;
                }
            }
            long c = 0;
            for (int i = 0; i < 16; i++)
            {
                c = c + C[i];
                c = c * 10;
            }
            c = c / 10;
            string s = c.ToString();
            if (carry == 1 && A[0] == 1 && B[0] == 1)
                s = two(s);
            else if (carry == 0 && (A[0] == 1 || B[0] == 1))
                s = two(s);
            return s;
        }

        string usumbinary(int[] A, int[] B, int a, int b)
        {
            int carry = 0;
            int e = 0, d = 0;
            int[] C = new int[16];
            for (int i = 0; i < 16; i++)
                C[i] = 0;
            for (int i = 15; i >= 0; i--)
            {
                e = A[i];
                d = B[i];
                if (i == 0)
                {
                    switch (e + d + C[i])
                    {
                        case 0:
                            C[i] = 0;
                            carry = 0;
                            break;

                        case 1:
                            C[i] = 1;
                            carry = 0;
                            break;

                        case 2:
                            C[i] = 0;
                            carry = 1;
                            break;

                        case 3:
                            C[i] = 1;
                            carry = 1;
                            break;
                    }
                }
                else if (e + d + C[i] == 3)
                {
                    C[i] = 1;
                    C[i - 1] = 1;
                }
                else if (e + d + C[i] == 2)
                {
                    C[i] = 0;
                    C[i - 1] = 1;
                }
                else if (A[i] + B[i] + C[i] == 1)
                {
                    C[i] = 1;
                    C[i - 1] = 0;
                }
                else if (e + d + C[i] == 0)
                {
                    C[i] = 0;
                    C[i - 1] = 0;
                }
            }
            long c = 0;
            for (int i = 0; i < 16; i++)
            {
                c += C[i];
                c *= 10;
            }
            c = c / 10;
            string s = c.ToString();
            if (a < 0 & b < 0)
            {
                s = utwo(s); neg = 1;
            }
            else if (carry == 0)
            {
                s = utwo(s); neg = 1;
            }
            return s;
        }

        string difbinary(int[] A, int[] B, int bin)
        {
            int carry = 0;
            int[] C = new int[16];
            for (int i = 0; i < 16; i++)
                C[i] = 0;
            for (int i = 15; i >= 0; i--)
            {
                int a = A[i], b = B[i];
                if (i == 0)
                {
                    switch (a + b + C[i])
                    {
                        case 0:
                            C[i] = 0;
                            carry = 0;
                            break;

                        case 1:
                            C[i] = 1;
                            carry = 0;
                            break;

                        case 2:
                            C[i] = 0;
                            carry = 1;
                            break;

                        case 3:
                            C[i] = 1;
                            carry = 1;
                            break;
                    }
                }
                else if (a + b + C[i] == 3)
                {
                    C[i] = 1;
                    C[i - 1] = 1;
                }
                else if (a + b + C[i] == 2)
                {
                    C[i] = 0;
                    C[i - 1] = 1;
                }
                else if (A[i] + B[i] + C[i] == 1)
                {
                    C[i] = 1;
                    C[i - 1] = 0;
                }
                else if (a + b + C[i] == 0)
                {
                    C[i] = 0;
                    C[i - 1] = 0;
                }
            }
            long c = 0;
            for (int i = 0; i < 16; i++)
            {
                c += C[i];
                c *= 10;
            }
            c = c / 10;
            string s = c.ToString();
            if (bin == 1)
            {
                s = utwo(s);
            }
            if (carry == 0)
                s = utwo(s);
            return s;
        }

        string udifbinary(int[] A, int[] B)
        {
            int carry = 0;
            int[] C = new int[16];
            for (int i = 0; i < 16; i++)
                C[i] = 0;
            for (int i = 15; i >= 0; i--)
            {
                int a = A[i], b = B[i];
                if (i == 0)
                {
                    switch (a + b + C[i])
                    {
                        case 0:
                            C[i] = 0;
                            carry = 0;
                            break;

                        case 1:
                            C[i] = 1;
                            carry = 0;
                            break;

                        case 2:
                            C[i] = 0;
                            carry = 1;
                            break;

                        case 3:
                            C[i] = 1;
                            carry = 1;
                            break;
                    }
                }
                else if (a + b + C[i] == 3)
                {
                    C[i] = 1;
                    C[i - 1] = 1;
                }
                else if (a + b + C[i] == 2)
                {
                    C[i] = 0;
                    C[i - 1] = 1;
                }
                else if (A[i] + B[i] + C[i] == 1)
                {
                    C[i] = 1;
                    C[i - 1] = 0;
                }
                else if (a + b + C[i] == 0)
                {
                    C[i] = 0;
                    C[i - 1] = 0;
                }
            }
            long c = 0;
            for (int i = 0; i < 16; i++)
            {
                c += C[i];
                c *= 10;
            }
            c = c / 10;
            string s = c.ToString();
            if (carry == 0)
            {
                s = utwo(s);
                neg = 1;
            }
            return s;
        }

        string H2B(string d)
        {
            string b = Convert.ToString((Convert.ToInt32(d, 16)), 2);
            return b;
        }

        string D2B(string d)
        {
            string b = Convert.ToString((Convert.ToInt32(d, 10)), 2);
            return b;
        }

        string uaddspace(string a)
        {
            int n = a.Length;
            string c = "0";

            for (int i = 16 - n; i != 0; i--)
                a = a.Insert(0, c);
            return a;
        }

        string two(string a)
        {
            char c = a[0];
            a = a.Remove(0, 1);
            int n = a.Length;
            int i;

            string ones;
            string twos;
            ones = twos = "";

            for (i = 0; i < n; i++)
            {
                ones += flip(a[i]);
            }

            twos = ones;
            for (i = n - 1; i >= 0; i--)
            {
                if (ones[i] == '1')
                {
                    twos = twos.Remove(i, 1);
                    twos = twos.Insert(i, "0");
                }
                else
                {
                    twos = twos.Remove(i, 1);
                    twos = twos.Insert(i, "1");
                    break;
                }
            }
            if (i == -1)
            {
                twos = '1' + twos;
            }

            return c + twos;
        }

        string utwo(string a)
        {
            int n = a.Length;
            int i;

            string ones;
            string twos;
            ones = twos = "";

            for (i = 0; i < n; i++)
            {
                ones += flip(a[i]);
            }

            twos = ones;
            for (i = n - 1; i >= 0; i--)
            {
                if (ones[i] == '1')
                {
                    twos = twos.Remove(i, 1);
                    twos = twos.Insert(i, "0");
                }
                else
                {
                    twos = twos.Remove(i, 1);
                    twos = twos.Insert(i, "1");
                    break;
                }
            }
            if (i == -1)
            {
                twos = '1' + twos;
            }

            return twos;
        }

        char flip(char c) { return (c == '0') ? '1' : '0'; }

        string addspace(string a)
        {
            int n = a.Length;
            char s = a[0];
            string c;
            if (a[0] == 49)
                c = "1";
            else
                c = "0";
            for (int i = 16 - n; i != 0; i--)
                a = a.Insert(0, c);
            a = s + a.Remove(0, 1);
            return a;
        }

        string OctToBin(string a)
        {
            string octnum = a;
            string binary = "";

            foreach (char c in a)
            {
                switch (c)
                {
                    case '0':
                        binary += "000";
                        break;
                    case '1':
                        binary += "001";
                        break;
                    case '2':
                        binary += "010";
                        break;
                    case '3':
                        binary += "011";
                        break;
                    case '4':
                        binary += "100";
                        break;
                    case '5':
                        binary += "101";
                        break;
                    case '6':
                        binary += "110";
                        break;
                    case '7':
                        binary += "111";
                        break;
                    default:
                        MessageBox.Show("Invalid Octal Digit", "Error!");
                        break;
                }
            }
            int x = binary.Length;
            string zeroes = "";
            for (int i = 0; i < 16 - x; i++)
            {
                zeroes = String.Concat(zeroes, "0");
            }
            zeroes = zeroes + binary;
            binary = zeroes;
            return binary;
        }

        string nOctToBin(string b)
        {
            string a = two(OctToBin(b));
            a = '1' + a.Remove(0, 1);
            return a;
        }

        private void InBin_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxSign.Show();
        }
    }
}
