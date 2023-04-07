using System;

namespace LaptopApp
{
    abstract class Laptop
    {
        protected string vga;
        protected string processor;

        public Laptop(string vga, string processor)
        {
            this.vga = vga;
            this.processor = processor;
        }

        public abstract void LaptopDinyalakan();

        public abstract void LaptopDimatikan();

        public abstract void BermainGame();

        public abstract void Ngoding();
    }

    class Vivobook : Laptop
    {
        public Vivobook(string vga, string processor) : base(vga, processor)
        {
        }

        public override void LaptopDinyalakan()
        {
            Console.WriteLine($"Laptop Vivobook dengan VGA {vga} dan Processor {processor} menyala");
        }

        public override void LaptopDimatikan()
        {
            Console.WriteLine($"Laptop Vivobook dengan VGA {vga} dan Processor {processor} dimatikan");
        }

        public override void BermainGame()
        {
            Console.WriteLine($"Laptop Vivobook dengan VGA {vga} dan Processor {processor} sedang memainkan game");
        }

        public override void Ngoding()
        {
            Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
        }
    }

    class IdeaPad : Laptop
    {
        public IdeaPad(string vga, string processor) : base(vga, processor)
        {
        }

        public override void LaptopDinyalakan()
        {
            Console.WriteLine($"Laptop IdeaPad dengan VGA {vga} dan Processor {processor} menyala");
        }

        public override void LaptopDimatikan()
        {
            Console.WriteLine($"Laptop IdeaPad dengan VGA {vga} dan Processor {processor} dimatikan");
        }

        public override void BermainGame()
        {
            Console.WriteLine($"Laptop IdeaPad dengan VGA {vga} dan Processor {processor} sedang memainkan game");
        }

        public override void Ngoding()
        {
            Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
        }
    }

    class Predator : Laptop
    {
        public Predator(string vga, string processor) : base(vga, processor)
        {
        }

        public override void LaptopDinyalakan()
        {
            Console.WriteLine($"Laptop Predator dengan VGA {vga} dan Processor {processor} menyala");
        }

        public override void LaptopDimatikan()
        {
            Console.WriteLine($"Laptop Predator dengan VGA {vga} dan Processor {processor} dimatikan");
        }

        public override void BermainGame()
        {
            Console.WriteLine($"Laptop Predator dengan VGA {vga} dan Processor {processor} sedang memainkan game");
        }

        public override void Ngoding()
        {
            Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
        }
    }
}
