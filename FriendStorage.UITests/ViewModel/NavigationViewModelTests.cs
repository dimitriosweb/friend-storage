using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendStorage.Model;
using FriendStorage.UI.DataProvider;
using FriendStorage.UI.ViewModel;
using Moq;
using Xunit;

namespace FriendStorage.UITests.ViewModel
{
    public class NavigationViewModelTests
    {
        private NavigationViewModel _viewModel;

        public NavigationViewModelTests()
        {
            var navigationDataProviderMock = new Mock<INavigationDataProvider>();
            navigationDataProviderMock.Setup(dp => dp.GetAllFriends()).Returns(new List<LookupItem>()
            {
                new LookupItem() {Id = 1, DisplayMember = "Freddy Mercury"},
                new LookupItem() { Id = 1, DisplayMember = "Bernardo Stefano" }
            });
            _viewModel = new NavigationViewModel(navigationDataProviderMock.Object);
        }
        [Fact]
        public void ShouldLoadFriends()
        {
       
            _viewModel.Load();

            
            Assert.Equal(2, _viewModel.Friends.Count);
        }
    }
}
