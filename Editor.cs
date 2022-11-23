using System.Text;

namespace HtmlEditor
{
    public class Editor
    {
        public static void Show()
        {
            Console.Clear();

            DrawScreen();

            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");

            Console.SetCursorPosition(2, 3);
            Console.WriteLine("-------------------------------------------------------------------------------");

            Start();
        }

        public static void DrawScreen()
        {
            Console.Clear();

            Console.Write("+");
            for(int i = 0; i <= 80; i++)
                Console.Write("-");

            Console.Write("+");
            Console.Write("\n");

            for(int lines = 0; lines <= 10; lines++)
            {
                Console.Write("|");
                for(int i = 0; i <= 80; i++)
                    Console.Write(" ");
                
                Console.Write("|");
                Console.Write("\n");
            }


            Console.Write("+");
            for(int i = 0; i <= 80; i++)
                Console.Write("-");

            Console.Write("+");
            Console.Write("\n");
            Console.Write("\n");
        }

        public static void Start()
        {
            var file = new StringBuilder();

            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("--------");
            Console.WriteLine("Deseja salvar o arquivo?");

            Console.Write("Opção: ");
            var option = short.Parse(Console.ReadLine());

            Viewer.Show(file.ToString());
        }
    }
}
