using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula25_05
{
    internal class Program
    {
        public static void Exercicio1()
        {
            Console.WriteLine("exercicio 1");

            int numdprod, pre, to = 0;

            while (true)
            {
                Console.WriteLine("DIGITE 0 PARA SAIR");
                Console.WriteLine("QUAL A QUANTIDADE DO PRODUTO? ");
                numdprod = int.Parse(Console.ReadLine());
                if (numdprod == 0)
                {
                    break;
                }
                Console.WriteLine("QUAL O PREÇO DO PRODUTO? ");
                pre = int.Parse(Console.ReadLine());

                to = pre * numdprod + to;

                if (to == 0)
                {
                    break;
                }

            }
            Console.WriteLine("o valor total:" + to);

        }
        public static void Exercicio2()
        {
            Console.WriteLine("exercicio 2");
            double v, q, vt, vm, u, vmL;

            string nom, nm, nmm;

            Console.WriteLine("ESCREVA O NOME DO PODUTO ('parar'- para parar)");

            nom = Console.ReadLine();

            if (nom == "parar")

            {



            }

            Console.WriteLine("DIGITE O VALOR DO PRUDUTO (UNIDADE)");

            v = double.Parse(Console.ReadLine());

            Console.WriteLine("digite o a quantidade do produto");

            q = double.Parse(Console.ReadLine());

            vt = q * v;

            vm = vt;

            nm = nom;

            vmL = vt;

            nmm = nom;

            while (nom != "parar")

            {

                Console.WriteLine("digite o nome do produto (digite 'parar' para parar)");

                nom = Console.ReadLine();

                if (nom == "parar")

                {

                    break;

                }

                Console.WriteLine("VALOR DO PRODUTO (UNIDADE)");

                v = double.Parse(Console.ReadLine());

                Console.WriteLine("QUANTIDADE DO PROUTO:");

                q = double.Parse(Console.ReadLine());

                vt = q * v;

                if (vt > vm)

                {

                    nm = nom;

                }

                if (vt < vmL)

                {

                    nmm = nom;

                }
                int a = 0;
                a++;
            }

            Console.WriteLine("PRODUTO COM MAIOR INVESTIMENTO: " + nm + " COM O TOTAL DE:" + vm + " PRODUTO COM MENOR INVESTIMENTO: " + nmm + " COM UM TOTAL DE " + vmL);
        }
        public static void Exercicio3()
        {
            Console.WriteLine("exercicio 3");
            double na, pda, pt;

            Console.WriteLine("quantas avaliações terão neste bimestre?");

            na = double.Parse(Console.ReadLine());

            pt = 0;
            int i = 0;
            while (i < na)

            {

                Console.WriteLine("qual o peso das avaliações (ex: 3)");

                pda = double.Parse(Console.ReadLine());

                pt = pt + pda;
                i++;

            }

            pt = pt * 10;

            if (pt > 100)

            {

                Console.WriteLine("\nOs pesos ultrapassam 100%");



            }

            if (pt == 100)

            {

                Console.WriteLine("\nOs pesos resultam em 100%");



            }

            if (pt > 100)

            {

                Console.WriteLine("\nOs pesos nao atingem 100%");



            }
        }
        public static void Exercicio4()
        {
            Console.WriteLine("exercicio 4");
            string estado;

            Console.WriteLine("qual a sigla do estado");

            estado = Console.ReadLine();

            switch (estado)

            {

                case "AC":

                    Console.WriteLine("o estado é: Acre");

                    break;

                case "AL":

                    Console.WriteLine("o estado é: Alagoas");

                    break;

                case "AP":

                    Console.WriteLine("o estado é: Amapá");

                    break;

                case "AM":

                    Console.WriteLine("o estado é: Amazonas");

                    break;

                case "BA":

                    Console.WriteLine("o estado é: Bahia");

                    break;

                case "CE":

                    Console.WriteLine("o estado é: Ceará");

                    break;

                case "DF":

                    Console.WriteLine("Distrito Federal não é um estado, mas sim uma uniudade autônoma");

                    break;

                case "ES":

                    Console.WriteLine("o estado é: Espírito Santo");

                    break;

                case "GO":

                    Console.WriteLine("o estado é: Goiás");

                    break;

                case "MA":

                    Console.WriteLine("o estado é: Maranhão");

                    break;

                case "MT":

                    Console.WriteLine("o estado é: Mato Grosso");

                    break;

                case "MS":

                    Console.WriteLine("o estado é: Mato Grosso do Sul");

                    break;

                case "MG":

                    Console.WriteLine("o estado é: Minas Gerais");

                    break;

                case "PA":

                    Console.WriteLine("o estado é: Pará");

                    break;

                case "PB":

                    Console.WriteLine("o estado é: Paraíba");

                    break;

                case "PR":

                    Console.WriteLine("o estado é: Paraná");

                    break;

                case "PE":

                    Console.WriteLine("o estado é: Pernambuco");

                    break;

                case "PI":

                    Console.WriteLine("o estado é: Piauí");

                    break;

                case "RJ":

                    Console.WriteLine("o estado é: Rio de Janeiro");

                    break;

                case "RN":

                    Console.WriteLine("o estado é: Rio Grande do Norte");

                    break;

                case "RS":

                    Console.WriteLine("o estado é: Rio Grande do Sul");

                    break;

                case "RO":

                    Console.WriteLine("o estado é: Rondônia");

                    break;

                case "RR":

                    Console.WriteLine("o estado é: Roraima");

                    break;

                case "SC":

                    Console.WriteLine("o estado é: Santa Catarina");

                    break;

                case "SP":

                    Console.WriteLine("o estado é: São Paulo");

                    break;

                case "SE":

                    Console.WriteLine("o estado é: Sergipe");

                    break;

                case "TO":

                    Console.WriteLine("o estado é: Tocantins");

                    break;

                default:

                    Console.WriteLine("nao existe estado com essa sigla");

                    break;

            }

        }
        public static void Exercicio5()
        {
            Console.WriteLine("exercicio 5");

            int m, d;

            Console.WriteLine("digite o mês");

            m = int.Parse(Console.ReadLine());

            switch (m)

            {

                case 1:

                    Console.WriteLine("a estação correspondente a este mês é: verão");

                    break;

                case 2:

                    Console.WriteLine("a estação correspondente a este mês é: verão");

                    break;

                case 3:

                    Console.WriteLine("qual é o dia?");

                    d = int.Parse(Console.ReadLine());

                    if (d < 20 && d > 1)

                        Console.WriteLine("a estação correspondente a este mês é: verão");

                    if (d >= 20 && d < 31)

                        Console.WriteLine("a estação correspondente a este mês é: outono");

                    break;

                case 4:

                    Console.WriteLine("a estação correspondente a este mês é: verão");

                    break;

                case 5:

                    Console.WriteLine("a estação correspondente a este mês é: verão");

                    break;

                case 6:

                    Console.WriteLine("qual é o dia?");

                    d = int.Parse(Console.ReadLine());

                    if (d < 21 && d > 1)

                        Console.WriteLine("a estação correspondente a este mês é: outono");

                    if (d >= 21 && d < 30)

                        Console.WriteLine("a estação correspondente a este mês é: inverno");

                    break;

                case 7:

                    Console.WriteLine("a estação correspondente a este mês é: inverno");

                    break;

                case 8:

                    Console.WriteLine("a estação correspondente a este mês é: inverno");

                    break;

                case 9:

                    Console.WriteLine("qual é o dia?");

                    d = int.Parse(Console.ReadLine());

                    if (d < 23 && d > 1)

                        Console.WriteLine("a estação correspondente a este mês é: inverno");

                    if (d >= 23 && d < 30)

                        Console.WriteLine("a estação correspondente a este mês é: primavera");

                    break;

                case 10:

                    Console.WriteLine("a estação correspondente a este mês é: primavera");

                    break;

                case 11:

                    Console.WriteLine("a estação correspondente a este mês é: primavera");

                    break;

                case 12:

                    Console.WriteLine("qual é o dia?");

                    d = int.Parse(Console.ReadLine());

                    if (d < 22 && d > 1)

                        Console.WriteLine("a estação correspondente a este mês é: primavera");

                    if (d >= 22 && d < 30)

                        Console.WriteLine("a estação correspondente a este mês é: verão");

                    break;

                default:

                    Console.WriteLine("o valor digitado é invalido");

                    break;

            }
        }
        public static void Exercicio6()
        {
            Console.WriteLine("exercicio 6");
            float peso, alt, imc;
            Console.WriteLine("Qual o seu peso ?");
            peso = float.Parse(Console.ReadLine());
            Console.WriteLine("Qual a sua altura ?");
            alt = float.Parse(Console.ReadLine());

            imc = peso / alt * alt;

            if (imc <= 18.5)
                Console.WriteLine("Abaixo do peso");
            else if (imc <= 24.9 && imc >= 18.5)
                Console.WriteLine("Peso normal");
            else if (imc >= 25 && imc <= 29.5)
                Console.WriteLine("Sobrepeso");
            else if (imc >= 30 && imc <= 34.9)
                Console.WriteLine("obesidade grau 1");
            else if (imc >= 35 && imc <= 39.9)
                Console.WriteLine("obsedidade grau 2");
            else
                Console.WriteLine("obsediade grau 3 (morbida)");
        }
        public static void Exercicio7()
        {
            Console.WriteLine("exercicio 7");
            int num, n;
            Console.WriteLine("Informe um número:");
            num = int.Parse(Console.ReadLine());

            if (num <= 0)
                Console.WriteLine("O número informado deve ser maior que 0!");

            string divisores = "";

            n = 1;
            while (n < num + 1)
            {
                if (num % n == 0) divisores += n + " ";
                n++;
            }

        }
        static void Main(string[] args)
        {
            int opcao;
            do
            {
                Console.WriteLine(">>>>MENU<<<<");
                Console.WriteLine("PARA SAIR 0");
                Console.WriteLine("EXERCICIO 1");
                Console.WriteLine("EXERCICIO 2");
                Console.WriteLine("EXERCICIO 3");
                Console.WriteLine("EXERCICIO 4");
                Console.WriteLine("EXERCICIO 5");
                Console.WriteLine(">>>>><<<<<<");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("obrigada");
                        break;
                    case 1:
                        Exercicio1();
                        break;
                    case 2:
                        Exercicio2();
                        break;
                    case 3:
                        Exercicio3();
                        break;
                    case 4:
                        Exercicio4();
                        break;
                    case 5:
                        Exercicio5();
                        break;
                    default:
                        Console.WriteLine("não existe esse exercicio");
                        break;

                }

            } while (opcao != 0);

        }
    }
}
