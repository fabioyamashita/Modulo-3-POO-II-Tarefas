using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sharprompt;

namespace LetsSpeak
{
    public class MenuItem
    {
        public MenuType Type { get; }
        private static MenuItem _root;
        private MenuItem parent = null;
        private string title;
        private List<MenuItem> items;
        private Action action;

        public MenuItem(string title)
        {
            this.title = title;
            items = new List<MenuItem>();
            if (_root == null) _root = this;
            Type = MenuType.Submenu;
        }

        public MenuItem(string title, Action action) : this(title)
        {
            this.action = action;
            Type = MenuType.Command;
        }

        public void Add(MenuItem menuItem)
        {
            menuItem.parent = this;
            items.Add(menuItem);
        }

        public void Execute()
        {
            Console.Clear();
            Console.ResetColor();

            var menuItems = Prompt.Select(title, items);

            switch (menuItems.Type)
            {
                case MenuType.Submenu:
                    menuItems.Execute();
                    break;

                case MenuType.Command:
                    menuItems.action();
                    Console.ReadKey(true);
                    break;

                default:
                    break;
            }

            menuItems.parent.Execute();
        }

        public override string ToString()
        {
            return title;
        }

    }
}
