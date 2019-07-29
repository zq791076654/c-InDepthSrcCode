using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter01.CSharp3
{
	class ListSortWithDelegate
	{
		static void Main()
		{
			List<Product> productList = Product.GetSampleProducts();
			productList.Sort
			(
				delegate (Product x, Product y)
				{
					return x.Name.CompareTo(y.Name);
				}
			);

			foreach (Product item in productList)
			{
				Console.WriteLine(item.Name);
			}
		}
	}
}
