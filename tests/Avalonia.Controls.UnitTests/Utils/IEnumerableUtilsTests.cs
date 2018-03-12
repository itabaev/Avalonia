using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using Avalonia.Controls.Utils;
using Xunit;

namespace Avalonia.Controls.UnitTests.Utils
{
    public class IEnumerableUtilsTests
    {
        [Fact]
        public void IEnumerable_IsEmpty()
        {
            var en = Enumerable.Empty<object>();
            Assert.True(en.IsEmpty());

            var list = new List<object>();
            Assert.True(list.IsEmpty());

            list.Add(1);
            Assert.False(list.IsEmpty());

            list.RemoveAt(0);
            Assert.True(list.IsEmpty());

            var dataTable = new DataTable("Test")
            {
                Columns = { { "Id", typeof(int) } }
            };
            Assert.True(dataTable.DefaultView.IsEmpty());

            dataTable.Rows.Add(1);
            Assert.False(dataTable.DefaultView.IsEmpty());

            dataTable.Rows.RemoveAt(0);
            Assert.True(dataTable.DefaultView.IsEmpty());
        }

        [Fact]
        public void IEnumerable_GetItemProperties()
        {
            var en = Enumerable.Empty<TestItem>();
            var properties = en.GetItemProperties();
            CheckTestItemProperties(properties);

            var list = new List<TestItem> { new TestItem { Id = 1, Name = "foo", CreateDate = DateTime.Now, IsActive = true } };
            properties = list.GetItemProperties();
            CheckTestItemProperties(properties);

            var array = new ArrayList { new TestItem { Id = 1, Name = "foo", CreateDate = DateTime.Now, IsActive = true } };
            properties = array.GetItemProperties();
            CheckTestItemProperties(properties);

            var dataTable = new DataTable("Test")
            {
                Columns =
                {
                    {nameof(TestItem.Id), typeof(int)},
                    {nameof(TestItem.Name), typeof(string)},
                    {nameof(TestItem.CreateDate), typeof(DateTime)},
                    {nameof(TestItem.IsActive), typeof(bool)}
                }
            };
            properties = dataTable.DefaultView.GetItemProperties();
            CheckTestItemProperties(properties);
        }

        private void CheckTestItemProperties(ReadOnlyCollection<ItemPropertyInfo> properties)
        {
            Assert.NotNull(properties);
            Assert.NotEmpty(properties);
            Assert.Equal(4, properties.Count);
            Assert.Contains(properties, x => x.Name == nameof(TestItem.Id) && x.PropertyType == typeof(int));
            Assert.Contains(properties, x => x.Name == nameof(TestItem.Name) && x.PropertyType == typeof(string));
            Assert.Contains(properties, x => x.Name == nameof(TestItem.CreateDate) && x.PropertyType == typeof(DateTime));
            Assert.Contains(properties, x => x.Name == nameof(TestItem.IsActive) && x.PropertyType == typeof(bool));
        }

        public class TestItem
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public DateTime CreateDate { get; set; }

            public bool IsActive { get; set; }
        }
    }
}
