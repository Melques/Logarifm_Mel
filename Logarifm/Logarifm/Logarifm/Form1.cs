using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.CodeDom.Compiler;

using System.Text.RegularExpressions;

namespace Logarifm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static void FormulaPrep(ref string str)
        {
            str = str.Replace('^', ',');
            Stack<int> brackets = new Stack<int>();
            int lstNumStart = 0;
            int endIndex = str.Length;
            int i = 0;
            char curChar;
            bool isPow = false;
            bool isBracketsPow = false;
            while (true)
            {
                if (i >= endIndex)
                {
                    if (isPow) { str = str.Insert(endIndex, ")"); }
                    break;
                }
                curChar = str[i];
                if(str[i] == ',')
                {
                    if (brackets.Count() > 0 && isBracketsPow)
                    {
                        str = str.Insert(brackets.Pop(), "pow(");
                        isBracketsPow = false;
                    }
                    else {
                        str = str.Insert(lstNumStart, "pow(");
                    }
                    endIndex = endIndex + 4;
                    isPow = true;
                    i = i + 6;
                    continue;

                }
                if (curChar == '(') {
                    brackets.Push(i); }
                if (curChar == ')')  {
                    if (i < endIndex - 1 && str[i + 1] == ',') {
                        isBracketsPow = true;
                    }
                    else brackets.Pop(); }
                if (!char.IsDigit(str[i]) &&  str[i] != 'x' && str[i] != 'X')
                {
                    lstNumStart = i + 1;
                    if (isPow)
                    {
                        str = str.Insert(i, ")");
                        isPow = false;
                        i = i+2;
                        endIndex++;
                        continue;
                    }
                }
                i++;
            }
        }

       
        private static Formula CreateFormula(string str)
        {
            string src =
            @"using System;
 
         static class Code
         {
             public static double Formula(double x, double y, double z)
             {
                 return {source};
             }
         }";
            str = Regex.Replace(str.ToLower(), @"[a-z]{3}", x =>
            {
                if (x.Value == "sin") return "Math.Sin";
                if (x.Value == "cos") return "Math.Cos";
                if (x.Value == "log") return "Math.Log";
                if (x.Value == "pow") return "Math.Pow";
                if (x.Value == "ppi") return "Math.PI";
                return x.Value;
            });
            src = src.Replace("{source}", str);
            var compiler = CodeDomProvider.CreateProvider("C#");
            var result = compiler.CompileAssemblyFromSource(new CompilerParameters(), src);
            if (result.Errors.Count == 0)
            {
                var assembly = result.CompiledAssembly;
                var type = assembly.GetType("Code");
                var method = type.GetMethod("Formula");
                return (Formula)Delegate.CreateDelegate(typeof(Formula), method);
            }
            return null;
        }

        public delegate double Formula(double x, double y, double z);

        private void btn_del_Click(object sender, EventArgs e)
        {
            /*
class Program
{
    
    static double Abs(double x)
    {
        return (x < 0) ? -x : x;
    }

    
    static int Sign(double x)
    {
        return (x < 0) ? -1 : 1;
    }

    
    static double BisectionMethod(Func<double, double> function, double a, double b, double precision = 1e-10)
    {
        while (true)
        {
            var t = (a + b) / 2;

            if (function(t) == 0.0 || Abs(b - a) < Abs(precision))
            {
                return t;
            }

            if (Sign(function(t)) == Sign(function(a)))
            {
                a = t;
            }
            else
            {
                b = t;
            }
        }
    }

    static void Main(string[] args)
    {
        
        double f(double x) => 3 * Math.Pow(x, 2) - 6 * x + 1;

        Console.WriteLine("3x^2 - 6x + 1");
        Console.Write("Введите начало отрезка: ");
        var a = double.Parse(Console.ReadLine());
        Console.Write("Введите конец отрезка: ");
        var b = double.Parse(Console.ReadLine());
        Console.Write("Введите точность вычислений: ");
        var eps = double.Parse(Console.ReadLine());

        var result = BisectionMethod(f, a, b, eps);
        Console.WriteLine("x = {0}\r\nf({0}) = {1}", result, f(result));
        Console.ReadKey();
    }
}*/
        }

        private void btn_sqr_Click(object sender, EventArgs e)
        {
            /*class Program
{
    static double LeftRectangle(Func<double, double> f, double a, double b, int n)
    {
        var h = (b - a) / n;
        var sum = 0d;
        for(var i = 0; i <= n-1; i++)
        {
            var x = a + i * h;
            sum += f(x);
        }

        var result = h * sum;
        return result;
    }

    static double RightRectangle(Func<double, double> f, double a, double b, int n)
    {
        var h = (b - a) / n;
        var sum = 0d;
        for (var i = 1; i <= n; i++)
        {
            var x = a + i * h;
            sum += f(x);
        }

        var result = h * sum;
        return result;
    }

    static double CentralRectangle(Func<double, double> f, double a, double b, int n)
    {
        var h = (b - a) / n;
        var sum = (f(a) + f(b)) / 2;
        for (var i = 1; i < n; i++)
        {
            var x = a + h * i;
            sum += f(x);
        }

        var result = h * sum;
        return result;
    }

    static void Main(string[] args)
    {
        
        double f(double x) => x / (x - 1);

        var result = LeftRectangle(f, 4, 10, 1000);
        Console.WriteLine("Формула левых прямоугольников: {0}", result);
        result = RightRectangle(f, 4, 10, 1000);
        Console.WriteLine("Формула правых прямоугольников: {0}", result);
        result = CentralRectangle(f, 4, 10, 1000);
        Console.WriteLine("Формула средних прямоугольников: {0}", result);

        Console.ReadKey();
    }
}*/
        }

        private void textSim_TextChanged(object sender, EventArgs e)
        {
            /**/
        }

        private void text_sqr_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_del_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_sim_Click(object sender, EventArgs e)
        {

        }

        private void btnFormula_Click(object sender, EventArgs e)
        {
            string str = FormulaTextBox.Text;
            string argS = ArgTextBox.Text;
            FormulaPrep(ref str);
            Formula f = CreateFormula(str);
            float x = float.Parse(argS);
            if (f != null)
            {
                resultTextBox.Text = f(x, 0, 0).ToString();
            }
            else
            {
                //resultTextBox.Text = str;
                resultTextBox.Text = "Введена некорректная функция!!!";
            }
            
        }
    }
}
