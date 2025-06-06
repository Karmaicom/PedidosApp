using Bogus;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;
using System.Net.Http.Json;

namespace PedidosApp.Api.Tests
{
    public class PedidosTest
    {
        #region Atributos
        private readonly HttpClient _httpClient;
        private readonly Faker _faker;
        private readonly string _apiUrl;
        #endregion

        #region Método construtor
        public PedidosTest()
        {
            _httpClient = new WebApplicationFactory<Program>().CreateClient();
            _faker = new Faker("pt_BR");
            _apiUrl = "/api/v1/pedidos";
        }
        #endregion

        [Fact(DisplayName = "Deve criar um pedido com sucesso.")]
        public async Task DeveCriarUmPedidoComSucesso ()
        {
            //Arrange
            var pedido = new
            {
                Solicitante = _faker.Name.FullName(),
                Valor = _faker.Finance.Amount(1, 1000),
                Data = _faker.Date.Future(),
                Descricao = _faker.Commerce.ProductDescription()
            };

            //Act
            var response = await _httpClient.PostAsJsonAsync(_apiUrl, pedido);

            //Assert
            response.StatusCode.Should().Be(HttpStatusCode.Created);
        }

        [Fact(Skip = "Não implementado")]
        public async Task DeveAlterarOsDadosDeUmPedido ()
        {

        }

        [Fact(Skip = "Não implementado")]
        public async Task DeveExcluirUmPedido ()
        {

        }

        [Fact(Skip = "Não implementado")]
        public async Task DeveConsultarUmPedidoAtravesDoId ()
        {

        }
    }
}
