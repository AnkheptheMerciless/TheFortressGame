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
            StorageItemsBox.SelectedIndex = 0;
        }

        private void FromLeftToRightSingle_Click(object sender, EventArgs e)
        {
            MoveElement(StorageItemsBox, ProdsInStorageStash, ProdsInSellStash, false);
        }
        private void FromLeftToRightAll_Click(object sender, EventArgs e)
        {
            MoveElement(StorageItemsBox, ProdsInStorageStash, ProdsInSellStash, true);
        }

        private void FromRightToLeftSingle_Click(object sender, EventArgs e)
        {
            MoveElement(SoldItemsBox, ProdsInSellStash, ProdsInStorageStash, false);
        }

        private void FromRightToLeftAll_Click(object sender, EventArgs e)
        {
            MoveElement(SoldItemsBox, ProdsInSellStash, ProdsInStorageStash, true);
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

        private void MoveElement(ListBox boxFrom, List<GeneratedProduct> listFrom, List<GeneratedProduct> listTo, bool all)
        {
            if (boxFrom.SelectedItem != null)
            {
                GeneratedProduct chosen = (GeneratedProduct)boxFrom.SelectedItem;
                var selectIndex = boxFrom.SelectedIndex;
                if (listTo.Any(p => p.Name == chosen.Name))
                {
                    if (chosen.Count > 0)
                    {
                        if (all == true)
                        {
                            listTo.First(p => p.Name == chosen.Name).Count += chosen.Count;
                            chosen.Count -= chosen.Count;
                        }
                        else
                        {
                            listTo.First(p => p.Name == chosen.Name).Count += 1;
                            chosen.Count -= 1;
                        }

                    }
                }
                else
                {
                    if (chosen.Count > 0)
                    {
                        if (all == true)
                        {
                            var newP = (GeneratedProduct)chosen.Clone();
                            newP.Count = chosen.Count;
                            chosen.Count -= chosen.Count;
                            listTo.Add(newP);
                        }
                        else
                        {
                            var newP = (GeneratedProduct)chosen.Clone();
                            chosen.Count -= 1;
                            newP.Count = 1;
                            listTo.Add(newP);
                        }

                    }

                }
                if (chosen.Count == 0)
                {
                    listFrom.Remove(chosen);

                }
                ChangeGainLabel();
                UpdateLists();
                if (boxFrom.Items.Count > 0)
                {
                    boxFrom.SelectedIndex = selectIndex;
                }
            }
        }

        private void ChangeGainLabel()
        {
            decimal totalGain = 0;
            if (ProdsInSellStash.Count > 0)
            {
                foreach (var item in ProdsInSellStash)
                {
                    totalGain += item.Price * item.Count;
                }

            }
            LabelGain.Text = $"You'll gain: {totalGain}";
        }
    }
}
