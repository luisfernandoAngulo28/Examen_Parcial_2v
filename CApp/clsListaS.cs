using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CApp
{
    public class clsListaS
    {

        //ATRIBUTOS DE LA CLASE
        private static int N = 5;
        public clsLista[] ListaS;
        public int[] B;//Tamanio de cada lista
        public int[] C;//contador de elemtos de lista

        //CONSTRUCTOR DE LA CLASE
        // MODIFICA EL CONSTRUCTOR DE LA CLASE -- con el fin de inicializar los ATRIBUTOS

        public clsListaS()
        {
            ListaS = new clsLista[N];
            B = new int[N];
            C = new int[N];
            //B[2|4|6|8|10]
            //C[1|0|0|0|0]
            for(int i = 0; i < N; i++)
            {
                ListaS[i] = new clsLista();
                B[i] = ((i + 1) * 2);
                C[i] = 0;
            }

        }

        

        //PROPIEDADES DE DESCRIPCION DE ACCESOS -- (get/set) que permite leer o cambiar los campos desde otras clases
        public clsLista[] listas
        {
            get { return ListaS; }
            set { ListaS = value; }
        }

        //AddS(L ,x) --> L // Adiciona el elemento x a la lista L
        public clsLista AddS(int i,int x)
        {
            if (!Llena(i))
            {
                ListaS[i].AddUltimo(x);
                C[i] = C[i] + 1;
            }
            return ListaS[i];
        }
        // 3. LlenaS(L ) -->Boolean  // Retorna true si L está llena
        public bool Llena(int i)
        {
            return (C[i] == B[i]);
        }
        public bool Vacia(int i)
        {
            return (C[i] == 0);
        }
        //4. DispoS(L )-- > N 
        // Retorna la cantidad de espacio disponible de la lista
        public int DispoS(int i)
        {
            return (B[i] - C[i]);
        }
        // 5. Long() --> N 
        // Retorna la cantidad de elementos de las n listas
        public int Long()
        {
            int s = 0;
            for(int i = 0; i < N; i++)
            {
                s = s + (B[i] - DispoS(i));
            }
            return s;
        }

        public String view()
        {
            String cad = "";
            for (int i = 1; i < N; i++)
            {
                cad = cad + " ( " + i + " ) " + ListaS[i].View(ListaS[i]) + "\n";

            }
            return cad + "null";
        }

    }
}
