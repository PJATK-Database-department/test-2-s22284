using System;
using Test2.DTO;

namespace Test2.Services
{
	public interface IClientService
	{
		Task<IEnumerable<ClientOrderDTO>> GetAllClientOrdersAsync(int IdClient);
	}
}

