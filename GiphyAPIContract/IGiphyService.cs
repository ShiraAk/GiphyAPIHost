using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace GiphyAPIContract
{
	[ServiceContract]
	public interface IGiphyService
	{
		[OperationContract]
		List<Gif> GetAllGiphy();

		[OperationContract]
		List<Gif> SearchGigphy(string search);
	}
}
