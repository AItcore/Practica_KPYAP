namespace _9
{
    class Element
    {
        private string name;
        private int enter;
        private int exit;

        public Element()
        {
        }
        public Element(string name)
        {
            this.name = name;
            this.Enter = 1;
            this.Exit = 1;
        }

        public Element(string name, int enter, int exit)
        {
            this.name = name;
            this.Enter = enter;
            this.Exit = exit;
        }

        public string Name { get => name; }
        public int Enter { get => enter; set => enter = value; }
        public int Exit { get => exit; set => exit = value; }
    }
}
