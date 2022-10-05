using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App5
{
    public class Database
    {
        private List<Item> items = new List<Item>();
        private int autoincriment = 4;


        public Database()
        {
            Item item = new Item 
            {
                Id = 1,
                Name = ""
            };

            Item item2 = new Item
            {
                Id = 2,
                Name = ""
            };

            Item item3 = new Item
            {
                Id = 3,
                Name = ""
            };


            Item item4 = new Item
            {
                Id = 4,
                Name = ""
            };

            items.Add(item);
            items.Add(item2);
            items.Add(item3);
            items.Add(item4);
        }
        
         
                     
        public Task<List<Item>> GetItems()
        {
            return Task.FromResult(items);
        }

       

        public Task AddItem(Item item)
        {
            item.Id = ++autoincriment;
            items.Add(item);
            return Task.CompletedTask; //Возвращает задачу, которая уже завершилась успешно.
        }

     

        public  Task DeleteItem(Item item)
        {

            items.Remove(item);
            return Task.CompletedTask;
        }
    }
}