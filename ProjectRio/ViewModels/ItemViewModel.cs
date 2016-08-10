using ProjectRio.Data;
using System;
using Windows.Globalization.DateTimeFormatting;

namespace ProjectRio.ViewModels
{
    public class ItemViewModel
    {
        private int _itemId;

        public int ItemId
        {
            get
            {
                return _itemId;
            }
        }

        public string DateCreatedHourMinute
        {
            get
            {
                var formatter = new DateTimeFormatter("longdate");
                return formatter.Format(DateCreated);
            }
        }

        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime DateCreated { get; set; }
        public string Description { get; set; }
        public ItemViewModel()
        {
        }

        public static ItemViewModel FromItem(Item item)
        {
            var viewModel = new ItemViewModel();

            viewModel._itemId = item.Id;
            viewModel.DateCreated = item.DateOfVisit;
            viewModel.Title = item.CityName;
            viewModel.Text = item.State;
            viewModel.Description = item.Description;

            return viewModel;
        }
    }
}
