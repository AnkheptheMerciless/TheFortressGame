using GameLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MainMenuForm
{
    public partial class TradeForm : Form
    {
        Random rnd = new Random();
        public List<GeneratedProduct> ProdsInStorageStash = new List<GeneratedProduct>();
        public List<GeneratedProduct> ProdsInSellStash = new List<GeneratedProduct>();
        public TradeForm()
        {
            InitializeComponent();
            foreach (var item in Fortress.CompletedProductsStorage)
            {
                ProdsInStorageStash.Add((GeneratedProduct)item.Clone());
            }
            StorageItemsBox.Items.AddRange(ProdsInStorageStash.ToArray());
        }

        private void FromLeftToRightSingle_Click(object sender, EventArgs e)
        {
            if (StorageItemsBox.SelectedItem != null)
            {
                GeneratedProduct chosen = (GeneratedProduct)StorageItemsBox.SelectedItem;
                if (ProdsInSellStash.Any(p => p.Name == chosen.Name))
                {
                    if (chosen.Count > 0)
                    {
                        ProdsInSellStash.First(p => p.Name == chosen.Name).Count += 1;
                        chosen.Count -= 1;
                    }
                }
                else
                {
                    if (chosen.Count > 0)
                    {
                        chosen.Count -= 1;
                        var newP = (GeneratedProduct)chosen.Clone();
                        newP.Count = 1;
                        ProdsInSellStash.Add(newP);
                    }

                }
                if (chosen.Count == 0)
                {
                    ProdsInStorageStash.Remove(chosen);
                }
                UpdateLists();
            }
        }
        private void FromLeftToRightAll_Click(object sender, EventArgs e)
        {
            if (StorageItemsBox.SelectedItem != null)
            {
                GeneratedProduct chosen = (GeneratedProduct)StorageItemsBox.SelectedItem;
                if (ProdsInSellStash.Any(p => p.Name == chosen.Name))
                {
                    if (chosen.Count > 0)
                    {
                        ProdsInSellStash.First(p => p.Name == chosen.Name).Count += chosen.Count;
                        chosen.Count -= chosen.Count;
                    }
                }
                else
                {
                    if (chosen.Count > 0)
                    {
                        var newP = (GeneratedProduct)chosen.Clone();
                        newP.Count = chosen.Count;
                        chosen.Count -= chosen.Count;
                        ProdsInSellStash.Add(newP);
                    }

                }
                if (chosen.Count == 0)
                {
                    ProdsInStorageStash.Remove(chosen);
                }
                UpdateLists();
            }
        }

        private void FromRightToLeftSingle_Click(object sender, EventArgs e)
        {
            if (SoldItemsBox.SelectedItem != null)
            {
                GeneratedProduct chosen = (GeneratedProduct)SoldItemsBox.SelectedItem;
                if (ProdsInStorageStash.Any(p => p.Name == chosen.Name))
                {
                    if (chosen.Count > 0)
                    {
                        ProdsInStorageStash.First(p => p.Name == chosen.Name).Count += 1;
                        chosen.Count -= 1;
                    }
                }
                else
                {
                    if (chosen.Count > 0)
                    {
                        chosen.Count -= 1;
                        var newP = (GeneratedProduct)chosen.Clone();
                        newP.Count = 1;
                        ProdsInStorageStash.Add(newP);
                    }

                }
                if (chosen.Count == 0)
                {
                    ProdsInSellStash.Remove(chosen);
                }
                UpdateLists();
            }
        }

        private void FromRightToLeftAll_Click(object sender, EventArgs e)
        {
            if (SoldItemsBox.SelectedItem != null)
            {
                GeneratedProduct chosen = (GeneratedProduct)SoldItemsBox.SelectedItem;
                if (ProdsInStorageStash.Any(p => p.Name == chosen.Name))
                {
                    if (chosen.Count > 0)
                    {
                        ProdsInStorageStash.First(p => p.Name == chosen.Name).Count += chosen.Count;
                        chosen.Count -= chosen.Count;
                    }
                }
                else
                {
                    if (chosen.Count > 0)
                    {
                        var newP = (GeneratedProduct)chosen.Clone();
                        newP.Count = chosen.Count;
                        chosen.Count -= chosen.Count;
                        ProdsInStorageStash.Add(newP);
                    }

                }
                if (chosen.Count == 0)
                {
                    ProdsInSellStash.Remove(chosen);
                }
                UpdateLists();
            }
        }

        private void SellButton_Click(object sender, EventArgs e)
        {
            Fortress.SoldItems = ProdsInSellStash;
            int decreaseChance;
            for (int i = 0; i < ProdsInSellStash.Count; i++)
            {
                decreaseChance = 10;
                GeneratedProduct current = ProdsInSellStash.First();
                Fortress.Treasury += current.Price * current.Count;
                decreaseChance += current.Count;
                if (current.Price > 1)
                {
                    if (decreaseChance > rnd.Next(100))
                    {
                        if (Fortress.CompletedProductsStorage.Any(p => p.Name == current.Name))
                        {
                            Fortress.CompletedProductsStorage.First(p => p.Name == current.Name).Price -= decreaseChance / 10;
                            if (Fortress.CompletedProductsStorage.First(p => p.Name == current.Name).Price < 1)
                            {
                                Fortress.CompletedProductsStorage.First(p => p.Name == current.Name).Price = 1;
                            }
                        }
                        Fortress.ProductTypes.First(p => p.Name == current.Name).Price -= decreaseChance / 10;
                        if (Fortress.ProductTypes.First(p => p.Name == current.Name).Price < 1)
                        {
                            Fortress.ProductTypes.First(p => p.Name == current.Name).Price = 1;
                        }
                    }
                }
                ProdsInSellStash.Remove(current);
            }
            Fortress.CompletedProductsStorage = ProdsInStorageStash;
            DialogResult = DialogResult.OK;
        }

        private void UpdateLists()
        {
            SoldItemsBox.Items.Clear();
            foreach (var item in ProdsInSellStash)
            {
                SoldItemsBox.Items.Add(item);
            }
            StorageItemsBox.Items.Clear();
            foreach (var item in ProdsInStorageStash)
            {
                StorageItemsBox.Items.Add(item);
            }
        }
    }
}
