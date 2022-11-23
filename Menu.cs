namespace HtmlEditor
{
    public class Menu
    {
        public static void Show()
        {
            DrawScreen();
            WriteOptions();

            var option = short.Parse(Console.ReadLine());

            HandleMenuOption(option);
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

        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");

            Console.SetCursorPosition(2, 3);
            Console.WriteLine("-------------------------------------------------------------------------------");

            Console.SetCursorPosition(3, 5);
            Console.WriteLine("Selecione uma opção abaixo:");

            Console.SetCursorPosition(3, 7);
            Console.WriteLine("1 - Novo arquivo");

            Console.SetCursorPosition(3, 8);
            Console.WriteLine("2 - Abrir Arquivo");

            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0 - Sair");

            Console.SetCursorPosition(3, 11);
            Console.Write("Opção: ");
            
        }

        public static void HandleMenuOption(short option)
        {
            switch(option)
            {
                case 1: Editor.Show(); break;
                case 2: Console.WriteLine("opção 2"); break;
                case 0: Console.Clear(); Environment.Exit(0); break;
                default: Show(); break;
            }
        }
    }
}