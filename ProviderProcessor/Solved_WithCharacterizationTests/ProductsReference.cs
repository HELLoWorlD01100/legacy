using System;

namespace ProviderProcessing.Solved_WithCharacterizationTests
{
	public class ProductsReference : IProductsReference
	{
		private static ProductsReference instance;

		public static ProductsReference GetInstance()
		{
			return instance ?? (instance = LoadReference());
		}

		public static ProductsReference LoadReference()
		{
			throw new NotImplementedException("������-������ ������������� �����������.");
		}

		public int? FindCodeByName(string name)
		{
			throw new NotImplementedException("������ �� ������������");
		}

		// ������ ������
	}

	public interface IProductsReference
	{
		int? FindCodeByName(string name);
	}
}