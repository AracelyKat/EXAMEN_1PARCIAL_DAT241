using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryNotacion
{
    public class Class1
    {
        public int Precedencia(char ch)
        {
            switch (ch)
            {
                case '+':
                case '-':
                    return 1;
                case '*':
                case '/':
                    return 2;
                case '^':
                    return 3;
                default:
                    return -1;
            }
        }

        public string ConvertirInfijoAPostfijo(string exp)
        {
            string resultado = "";
            Stack<char> pila = new Stack<char>();

            for (int i = 0; i < exp.Length; i++)
            {
                char c = exp[i];

                if (char.IsDigit(c) || c == '.')
                {
                    while (i < exp.Length && (char.IsDigit(exp[i]) || exp[i] == '.'))
                    {
                        resultado += exp[i];
                        i++;
                    }
                    resultado += ' ';
                    i--;
                }
                else if (c == '(')
                    pila.Push(c);
                else if (c == ')')
                {
                    while (pila.Count > 0 && pila.Peek() != '(')
                        resultado += pila.Pop() + " ";
                    pila.Pop();
                }
                else
                {
                    while (pila.Count > 0 && Precedencia(c) <= Precedencia(pila.Peek()))
                        resultado += pila.Pop() + " ";
                    pila.Push(c);
                }
            }

            while (pila.Count > 0)
                resultado += pila.Pop() + " ";

            return resultado.Trim();
        }

        public double EvaluarPostfijo(string exp)
        {
            Stack<double> pila = new Stack<double>();
            string[] tokens = exp.Split(' ');

            foreach (string token in tokens)
            {
                if (double.TryParse(token, out double numero))
                {
                    pila.Push(numero);
                }
                else
                {
                    double val1 = pila.Pop();
                    double val2 = pila.Pop();

                    switch (token)
                    {
                        case "+":
                            pila.Push(val2 + val1);
                            break;
                        case "-":
                            pila.Push(val2 - val1);
                            break;
                        case "*":
                            pila.Push(val2 * val1);
                            break;
                        case "/":
                            pila.Push(val2 / val1);
                            break;
                    }
                }
            }
            return pila.Pop();
        }
    }
}
