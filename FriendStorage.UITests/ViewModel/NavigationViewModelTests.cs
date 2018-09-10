using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendStorage.Model;
using FriendStorage.UI.DataProvider;
using FriendStorage.UI.ViewModel;
using Xunit;

namespace FriendStorage.UITests.ViewModel
{
    public class NavigationViewModelTests
    {
        [Fact]
        public void ShouldLoadFriends()
        {
            var viewModel = new NavigationViewModel(new NavigationDataProviderMock());
            viewModel.Load();

            
            Assert.Equal(2, viewModel.Friends.Count);
        }
    }

    public class NavigationDataProviderMock : INavigationDataProvider
    {
        public IEnumerable<LookupItem> GetAllFriends()
        {
            yield return new LookupItem() {Id = 1, DisplayMember = "Freddy Mercury"};
            yield return new LookupItem() {Id = 1, DisplayMember = "Bernardo Stefano"};
        }
    }
}
