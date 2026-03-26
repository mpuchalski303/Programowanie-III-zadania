/*
 Stwórz klasę Pisarz, posiadającą metodę Wypisz(-), wypisującą na ekran zawartość podanego parametru rzutowanego na typ String. 

W metodzie Main() stwórz obiekt klasy Pisarz i dwa wątki uruchamiane z metodą Wypisz(-) tego obiektu, wypisujące ciągle informację o swojej nazwie (zadbaj o to aby przypisać im nazwę używając własności Name). Sprawdź jak wątki zachowują się podczas zmiany priorytetów.

Niech każde wypisanie informacji wiąże się z wypisaniem w odstępie 10 milisekund 10 ponumerowanych linijek z nazwą wątku.

Zsynchronizuj wątki za pomocą (bieżącego) obiektu klasy Pisarz tak, aby wypisywane linijki nie przeplatały się.
 */
namespace Watki_zadanie_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pisarz pis1 = new Pisarz();

        }
    }
}
