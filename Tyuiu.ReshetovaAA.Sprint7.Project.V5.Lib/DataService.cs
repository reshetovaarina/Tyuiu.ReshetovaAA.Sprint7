using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;

namespace Tyuiu.ReshetovaAA.Sprint7.Project.V5.Lib
{
    // одна запись товара
    public class Product
    {
        // св-ва  (get; set;) –  для DataGridView
        public string Code { get; set; }      // код товара
        public string Name { get; set; }      // название товара
        public int Quantity { get; set; }     // количество на складе
        public double Price { get; set; }     // цена за единицу
        public string Note { get; set; }      // примечание
    }

    public class DataService
    {
        public List<Product> Products { get; private set; } = new List<Product>();

        public void AddProduct(Product product)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product));

            Products.Add(product);
        }

        // загрузка из csv: Код;Название;Количество;Цена;Примечание
        public void LoadFromCsv(string path)
        {
            Products.Clear();

            if (!File.Exists(path))
                return;

            string[] lines = File.ReadAllLines(path);

            foreach (string rawLine in lines)
            {
                if (string.IsNullOrWhiteSpace(rawLine))
                    continue;

                string line = rawLine.Trim();
                string lower = line.ToLower();

                // пропуск возможной строки-заголовка
                if (lower.Contains("код") && lower.Contains("наз"))
                    continue;

                string[] parts;
                if (line.Contains(";"))
                    parts = line.Split(';');
                else
                    parts = line.Split(',');

                if (parts.Length < 5)
                    continue;

                Product p = new Product();

                p.Code = parts[0].Trim();
                p.Name = parts[1].Trim();

                int q;
                if (!int.TryParse(parts[2].Trim(), out q))
                    q = 0;
                p.Quantity = q;

                double pr;
                string priceText = parts[3].Trim().Replace(',', '.');
                if (!double.TryParse(priceText, NumberStyles.Any,
                        CultureInfo.InvariantCulture, out pr))
                    pr = 0;
                p.Price = pr;

                p.Note = parts[4].Trim();

                Products.Add(p);
            }
        }

        public void SaveToCsv(string path)
        {
            string[] lines = new string[Products.Count];

            for (int i = 0; i < Products.Count; i++)
            {
                Product p = Products[i];

                lines[i] =
                    p.Code + ";" +
                    p.Name + ";" +
                    p.Quantity.ToString() + ";" +
                    p.Price.ToString(CultureInfo.InvariantCulture) + ";" +
                    p.Note;
            }

            File.WriteAllLines(path, lines);
        }

        public List<Product> SearchByName(string text)
        {
            List<Product> result = new List<Product>();

            if (string.IsNullOrWhiteSpace(text))
            {
                result.AddRange(Products);
                return result;
            }

            string lower = text.ToLower();

            foreach (Product p in Products)
            {
                if (!string.IsNullOrEmpty(p.Name) &&
                    p.Name.ToLower().Contains(lower))
                {
                    result.Add(p);
                }
            }

            return result;
        }
    }
}
