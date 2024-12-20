using System;
using System.Collections.Generic;

namespace ColoringApp
{
    // Classe principal do aplicativo
    public class App
    {
        public User CurrentUser { get; set; }
        public Canvas AppCanvas { get; set; }

        public void RunApp()
        {
            Console.WriteLine("Bem-vindo ao Aplicativo de Pintura!");
            // Lógica inicial do aplicativo
        }
    }

    // Representa um usuário
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public List<Achievements> Achievements { get; set; } = new List<Achievements>();

        public void SelectDrawing(Drawing drawing)
        {
            Console.WriteLine($"Desenho {drawing.Name} selecionado!");
        }
    }

    // Representa um desenho
    public class Drawing
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public int AgeGroup { get; set; }

        public void Load()
        {
            Console.WriteLine($"Carregando o desenho: {Name}");
        }

        public void Save()
        {
            Console.WriteLine($"Salvando o progresso do desenho: {Name}");
        }
    }

    // Representa a paleta de cores
    public class ColorPalette
    {
        public List<string> Colors { get; set; } = new List<string>();

        public string MixColors(string color1, string color2)
        {
            // Simulação de mistura de cores
            string mixedColor = $"{color1}-{color2}";
            Console.WriteLine($"Misturando {color1} e {color2}: Resultado {mixedColor}");
            return mixedColor;
        }
    }

    // Representa o canvas de pintura
    public class Canvas
    {
        public Drawing CurrentDrawing { get; set; }
        public ColorPalette Palette { get; set; } = new ColorPalette();

        public void FillArea(int x, int y, string color)
        {
            Console.WriteLine($"Área preenchida em ({x}, {y}) com a cor {color}.");
        }

        public void DrawLine(int startX, int startY, int endX, int endY, string color)
        {
            Console.WriteLine($"Linha desenhada de ({startX}, {startY}) até ({endX}, {endY}) com a cor {color}.");
        }
    }

    // Representa uma história interativa
    public class Story
    {
        public string Text { get; set; }
        public Drawing RelatedDrawing { get; set; }

        public void PlayStory()
        {
            Console.WriteLine("Iniciando a história interativa...");
            Console.WriteLine(Text);
        }
    }

    // Representa as conquistas do usuário
    public class Achievements
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public void Unlock()
        {
            Console.WriteLine($"Conquista desbloqueada: {Title}");
        }
    }

    // Programa principal
    class Program
    {
        static void Main(string[] args)
        {
            App app = new App();
            app.RunApp();

            // Simulação de uso
            User user = new User { Id = 1, Name = "João", Age = 7 };
            Drawing drawing = new Drawing { Id = 101, Name = "Desenho de Gato", AgeGroup = 7 };
            user.SelectDrawing(drawing);

            Canvas canvas = new Canvas { CurrentDrawing = drawing };
            canvas.FillArea(10, 20, "Azul");
            canvas.DrawLine(0, 0, 50, 50, "Vermelho");

            Story story = new Story { Text = "Era uma vez um lindo arco-íris...", RelatedDrawing = drawing };
            story.PlayStory();

            Achievements achievement = new Achievements { Title = "Primeira Pintura", Description = "Complete seu primeiro desenho!" };
            achievement.Unlock();
        }
    }
}

