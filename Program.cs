using System;

internal class Program
{
    private static void Main(string[] args)
    {
        p();
        void p()
        {
            Console.Write("alegeti numarul problemei:");
            int a = 1;
            while (a != 0)
            {
                a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 0:
                        a = 0;
                        break;
                    case 1:
                        p1();
                        p();
                        break;
                    case 2:
                        p2();
                        p();
                        break;
                    case 3:
                        p3();
                        p();
                        break;
                    case 4:
                        p4();
                        p();
                        break;
                    case 5:
                        p5();
                        p();
                        break;
                    case 6:
                        p6();
                        p();
                        break;
                    case 7:
                        p7();
                        p();
                        break;
                    case 8:
                        p8();
                        p();
                        break;
                    case 9:
                        p9();
                        p();
                        break;
                    case 10:
                        p10();
                        p();
                        break;
                    case 11:
                        p11();
                        p();
                        break;
                    case 12:
                        p12();
                        p();
                        break;
                    case 13:
                        p13();
                        p();
                        break;
                    case 14:
                        p14();
                        p();
                        break;
                    case 15:
                        p15();
                        p();
                        break;
                    case 16:
                        p16();
                        p();
                        break;
                    case 17:
                        p17();
                        p();
                        break;
                }
                break;
            }
        }
        void p1()
        {
            Console.WriteLine("cerinta problemei:");
            Console.WriteLine("Se da o secventa de n numere. Sa se determine cate din ele sunt pare. ");
            int n, x = 0, a;
            Console.Write("n:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("secventa:");
            for (int i = 0; i < n; i++)
            {
                a = int.Parse(Console.ReadLine());
                if (a % 2 == 0)
                    x++;
            }
            if (x > 0)
                Console.WriteLine($"{x} din cele {n} numere sunt pare");
            else
                Console.WriteLine($"nu exista numere pare in cele {n} numere introduse");
        }
        void p2()
        {
            Console.WriteLine("cerinta problemei:");
            Console.WriteLine("Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive. ");
            int n, x1 = 0, x2 = 0, x3 = 0;
            double a;
            Console.Write("n:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("secventa:");
            for (int i = 0; i < n; i++)
            {
                a = double.Parse(Console.ReadLine());
                if (a < 0)
                    x1++;
                if (a == 0)
                    x2++;
                if (a > 0)
                    x3++;

            }
            if(x1 != 1)
            Console.WriteLine($"din cele {n} numere introduse {x1} sunt negative, {x2} sunt 0 si {x3} pozitive");
        }
        void p3()
        {
            Console.WriteLine("cerinta problemei:");
            Console.WriteLine("Calculati suma si produsul numerelor de la 1 la n. ");
            int n, s = 0, p = 1;
            Console.Write("n:");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                s = s + i;
                p = p * i;
            }
            Console.WriteLine($"suma numerelor de la 1 la {n} este {s}, produsul numerelor de la 1 la {n} este {p}");
        }
        void p4()
        {
            Console.WriteLine("cerinta problemei:");
            Console.WriteLine("Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numara a. Se considera ca primul element din secventa este pe pozitia zero. Daca numarul nu se afla in secventa raspunsul va fi -1. ");
            int n, v = -1;
            double a,x;
            Console.Write("n:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("secventa:");
            a = double.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                x = double.Parse(Console.ReadLine());
                if (x == a)
                    v = i;
            }
            Console.WriteLine($"numarul {a} se afla pe pozitia {v}");
        }
        void p5()
        {
            Console.WriteLine("cerinta problemei:");
            Console.WriteLine("Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa. Se considera ca primul element din secventa este pe pozitia 0. ");
            int n, v = 0;
            double a;
            Console.Write("n:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("secventa:");
            for (int i = 0; i < n; i++)
            {
                a = double.Parse(Console.ReadLine());
                if (a == i)
                    v++;
            }
            Console.WriteLine($"{v} elemente din secventa de {n} numere sunt egale cu pozitia pe care apar in secventa");
        }
        void p6()
        {
            Console.WriteLine("cerinta problemei:");
            Console.WriteLine("Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare. ");
            int n;
            bool v = false;
            double a, aux;
            Console.Write("n:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("secventa:");
            a = double.Parse(Console.ReadLine());
            aux = a;
            for (int i = 0; i < n-1; i++)
            {
                a = double.Parse(Console.ReadLine());
                if (a < aux)
                    v = true;
                aux = a;
            }
            if (v)
                Console.WriteLine($"numerele din secventa nu sunt in ordine crescatoare");
            else
                Console.WriteLine("numerele din secevnta sunt in ordine crescatoare");
        }
        void p7()
        {
            Console.WriteLine("cerinta problemei:");
            Console.WriteLine("Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa. ");
            int n;
            double a, mx, mn;
            Console.Write("n:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("secventa:");
            a = double.Parse(Console.ReadLine());
            mx = a;
            mn = a;
            for (int i = 0; i < n - 1; i++)
            {
                a = double.Parse(Console.ReadLine());
                if (mn > a)
                    mn = a;
                if (mx < a)
                    mx = a;
            }
            Console.WriteLine($"cea mai mare valoare din secventa este {mx}, iar cea mai mica este {mn}");
        }
        void p8()
        {
            Console.Write("cerinta problemei:");
            Console.Write("Determianti al n-lea numar din sirul lui Fibonacci. Sirul lui Fibonacci se construieste astfel: f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2). Exemplu: 0, 1, 1, 2, 3, 5, 8 ...");
            int n, s = 0, aux = 0, aux2 = 1;
            Console.Write("n:");
            n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n -1; i++)
            {
                s = aux + aux2;
                aux = aux2;
                aux2 = s;
            }
            Console.WriteLine($"al {n}-lea numar din sirul lui Fibonacci este {s}");
        }
        void p9()
        {
            Console.WriteLine("cerinta problemei:");
            Console.WriteLine("Sa se determine daca o secventa de n numere este monotona. Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare. ");
            int n, v1 = 0;
            double a, aux;
            Console.Write("n:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("secventa:");
            a = double.Parse(Console.ReadLine());
            aux = a;
            for (int i = 0; i < n - 1; i++)
            {
                a = double.Parse(Console.ReadLine());

                if (a < aux && v1 == 2)
                {
                    v1 = -1;
                    break;
                }
                if (a < aux)                
                    v1 = 1;
                if (a > aux)
                    v1 = 2;
                
                if (a > aux && v1 == 1)
                {
                    v1 = -1;
                    break;
                }
                    aux = a;

            }
            if (v1 == -1)
                Console.WriteLine("nu");
            else
                Console.WriteLine("da");
        }
        void p10()
        {
            Console.WriteLine("cerinta problemei:");
            Console.WriteLine("Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa. ");
            int mxnc = 1, n, a, aux, nc = 0, nc2 = 0;
            // mxc = maximul de nr consecutive
            // nc = nr consecutive crescator
            // nc2 = nr consecutive descrescator
            Console.Write("n:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("secventa:");
            aux = int.Parse(Console.ReadLine());
            
                for (int i = 0; i < n - 1; i++)
            {
                a = int.Parse(Console.ReadLine());
                if (aux > a)
                {
                    nc++;
                    nc2 = 1;
                }
                if (aux == a)
                {
                    nc++;
                    nc2++;
                }
                if (aux < a)
                {
                    nc = 1;
                    nc2++;
                }
                if (mxnc < nc)
                    mxnc = nc;
                if (mxnc < nc2)
                    mxnc = nc2;
                aux = a;
            }
            Console.WriteLine($"numarul maxim de numere consecutive egale din secventa este {mxnc}");
        }
        void p11()
        {
            Console.WriteLine("cerinta problemei:");
            Console.WriteLine("Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere. ");
            int n, p = 10, a, s = 0, aux;
            Console.Write("n:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("secventa:");
            for (int i = 0; i < n; i++)
            {
                aux = 0;
                a = int.Parse(Console.ReadLine());
                while (a > 0)
                {
                    aux = p * aux + (a % 10);
                    a = a / 10;
                }
                s = s + aux;
            }
            Console.WriteLine($"suma inverselor este {s}");
        }
        void p12()
        {
            Console.WriteLine("cerinta problemei:");
            Console.WriteLine("Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere. Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte.");
            int n, a, aux, c = 0, ng = 0;
            // c = consecutive
            // ng = numar grupuri
            Console.Write("n:");
            n = int.Parse(Console.ReadLine());
            Console.Write("x:");
            aux = int.Parse(Console.ReadLine());
            for (int i = 0; i <n-1; i++)
            {
                Console.Write("x:");
                a = int.Parse(Console.ReadLine());
                if (aux <= a)
                    c++;
                if (a == 0)
                    c = 0;
                if (c == 1)
                    ng++;
                aux = a;
            }
            Console.WriteLine($"numarul de grupuri de numere consecutive din secventa de {n} numere este {ng}");
        }
        void p13()
        {
            Console.WriteLine("cerinta problemei:");
            Console.WriteLine("O <secventa crescatoare rotita> este o secventa de numere care este in ordine crescatoare sau poate fi transformata intr-o secventa in ordine crescatoare prin rotiri succesive (rotire cu o pozitie spre stanga = toate elementele se muta cu o pozitie spre stanga si primul element devine ultimul). Determinati daca o secventa de n numere este o secventa crescatoare rotita. ");
            int n, aux, a, a1;
            bool cr1 = false, cr2 = false;
            // cr = secventa crescatoare
            // a1 = primul element
            Console.Write("n:");
            n = int.Parse(Console.ReadLine());
            if (n == 2)
                Console.WriteLine("secventa este crescatoare rotita");
            else
            {
                Console.WriteLine("secventa:");
                aux = int.Parse(Console.ReadLine());
                a1 = aux;
                for (int i = 0; i < n - 1; i++)
                {
                    a = int.Parse(Console.ReadLine());
                    if (a >= aux)
                        cr1 = true;
                    if (a < aux)
                    {
                        if (cr2 == true)
                        {
                            Console.WriteLine("secventa nu este crescatoare rotita");
                            cr1 = false;
                            break;
                        }
                        cr2 = true;

                    }
                    if (a > a1 && cr2 == true)
                        cr1 = false;
                    aux = a;
                }
            if (cr1 == true)
                Console.WriteLine("secventa este crescatoare rotita");
            else
                Console.WriteLine("secventa nu este crescatoare rotita"); 
            }
        }
        void p14()
        {
            Console.WriteLine("cerinta problemei:");
            Console.WriteLine("O <secventa monotona rotita> este o secventa de numere monotona sau poate fi transformata intr-o secventa montona prin rotiri succesive. Determinati daca o secventa de n numere este o secventa monotona rotita. \r\n");
            int n, aux, a, a1;
                bool v1 = false, v2 = false;
            Console.Write("n:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("secventa:");
            aux = int.Parse(Console.ReadLine());
                a1 = aux;
                if (n == 2)
                    Console.WriteLine("secventa este montona rotita");
           for (int i = 0; i < n - 1; i++)
            {
                a = int.Parse(Console.ReadLine());

                if (a > aux)
                {
                    if (a >= aux)
                        v1 = true;
                    if (a < aux)
                    {
                        if (v2 == true)
                        {
                            Console.WriteLine("secventa nu este monotona rotita");
                            v1 = false;
                            break;
                        }
                        v2 = true;

                    }
                    if (a > a1 && v2 == true)
                        v1 = false;
                }
                else
                {
                    if (a < aux)
                    {
                        v1 = true;
                        if (a <= aux)
                        {
                            if (v2 == true)
                            {
                                Console.WriteLine("secventa nu este monotona rotita");
                                v2 = false;
                                break;
                            }
                            v1 = true;

                        }
                        if (a < a1 && v2 == true)
                            v1 = false;
                    }
                    
                }
           
                 aux = a;
                
           }
                if (v1 == true)
                    Console.WriteLine("secventa este monotona rotita");
                else
                    Console.WriteLine("secventa nu este monotona rotita");
        }
        void p15()
        {
            Console.WriteLine("cerinta problemei:");
            Console.WriteLine("O secventa bitonica este o secventa de numere care incepe monoton crescator si continua monoton descrecator. Se da o secventa de n numere. Sa se determine daca este bitonica. ");
            int n, aux, a;
            bool cr = false, dcr = false,v = true;
            Console.Write("n:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("secventa:");
            aux = int.Parse(Console.ReadLine());
            for (int i = 0; i < n -1; i++)
            {
                a = int.Parse(Console.ReadLine());
                if (a >= aux)
                {
                    if (dcr == true && a > aux)
                    {
                        v = false;
                        break;
                    }
                    cr = true;
                }
                if (cr == true && a < aux)
                    dcr = true;
            }
            if (v == true)
                Console.WriteLine("secventa este bitonica");
            else
                Console.WriteLine("secventa nu este bitonica");
            
        }
        void p16()
        {
            Console.WriteLine("cerinta problemei:");
            Console.WriteLine("O <secventa bitonica rotita> este o secventa bitonica sau una ca poate fi transformata intr-o secventa bitonica prin rotiri succesive (rotire = primul element devine ultimul). Se da o secventa de n numere. Se cere sa se determine daca este o secventa bitonica rotita. ");
            int n, aux, a, a1;
            bool cr = false, dcr = false, v = true, cr2 = false;
            Console.Write("n");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("secventa:");
            aux = int.Parse(Console.ReadLine());
            a1 = aux;
            for (int i = 0; i < n - 1; i++)
            {
                a = int.Parse(Console.ReadLine());
                if (a >= aux)
                {
                    cr = true;
                    if (dcr == true)
                    {
                        cr2 = true;
                    }
                }
                if (cr == true && a < aux)
                {
                    dcr = true;
                    if (dcr == true && cr2 == true && a < aux)
                        v = false;
                }
                if (cr2 == true && a > aux && a <= a1)
                    v = true;
                aux = a;
            }
            if (v == true)
                Console.WriteLine("secventa este bitonica rotita");
            else
                Console.WriteLine("secventa nu este bitonica rotita");
        }
        void p17()
        {
            Console.WriteLine("cerinta problemei:");
            Console.WriteLine("Se da o secventa de 0 si 1, unde 0 inseamna paranteza deschisa si 1 inseamna paranteza inchisa. Determinati daca secventa reprezinta o secventa de paranteze corecta si,  daca este, determinati nivelul maxim de incuibare a parantezelor.");
            int z = 0, u = 0, a, n, cz = 0, aux = -1;
            // z = zero
            // u = unu
            // cz = consecutiv zero
            Console.Write("n:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("secventa:");
            for (int i = 0; i < n; i++)
            {
                a = int.Parse(Console.ReadLine());
                if (a == 0)
                    z++;
                else
                    u++;
                if (u > z)
                {
                    Console.WriteLine("secventa nu este corecta");
                    break;
                }
                if (aux == a)
                    cz++;
                aux = a;

            }
            if (z == u)
            {
                Console.WriteLine("secventa este corecta");
                Console.WriteLine($"nivelul maxim de incuibare al parantezelor este {cz}");
            }
        }
    }
}
