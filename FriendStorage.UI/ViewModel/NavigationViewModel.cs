﻿using System;
using System.Collections.ObjectModel;
using FriendStorage.DataAccess;
using FriendStorage.Model;
using FriendStorage.UI.DataProvider;

namespace FriendStorage.UI.ViewModel
{
    public class NavigationViewModel : ViewModelBase
    {
        public NavigationViewModel(INavigationDataProvider dataProvider)
        {
            Friends = new ObservableCollection<LookupItem>();
            _dataProvider = dataProvider;
        }
        public void Load()
        {   
            foreach (var friend in _dataProvider.GetAllFriends())
            {
                Friends.Add(friend);
            }
        }

        public ObservableCollection<LookupItem> Friends { get; private set; }

        private INavigationDataProvider _dataProvider;
    }
}
