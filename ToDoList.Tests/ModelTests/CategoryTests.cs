using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;
using System.Collections.Generic;
using System;

namespace ToDoList.Tests
{
  [TestClass]
  public class CategoryTest : IDisposable
  {
    public void Dispose()
    {
      Category.ClearAll();
    }

    [TestMethod]
    public void CategoryConstructor_CreatesInstanceOfCategory_Category()
      {
        Category newCategory = new Category("test category");
        Assert.AreEqual(typeof(Category), newCategory.GetType());
      }

      [TestMethod]
      public void GetId_ReturnsCategoryId_Int()
      {
        string name = "Test Category";
        Category newCategory = new Category(name);

        int result = newCategory.Id;

        Assert.AreEqual(1, result);
      }

      [TestMethod]
      public void GetAll_ReturnsAllCategoryObjects_CategoryList()
      {
        string name01 = "Work";
        string name02 = "School";
        Category newCategory1 = new Category(name01);
        Category newCategory2 = new Category(name02);
        List<Category> newList = new List<Category> { newCategory1, newCategory2 };

        // string name03 = "Walk Dog";
        // string name04 = "Feed Dog";
        // Category sampleCategory = new Category(name03);
        // Category sampleCategory2 = new Category(name04);
        List<Category> result = Category.GetAll();

        CollectionAssert.AreEqual(newList, result);
      } 
  }
}