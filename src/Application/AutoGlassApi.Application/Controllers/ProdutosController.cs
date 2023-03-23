using AutoGlassApi.Application.ViewModels;
using AutoGlassApi.Domain.Dtos;
using AutoGlassApi.Domain.Interfaces.Services;
using AutoGlassApi.Domain.Parameters;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace AutoGlassApi.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutosController : ControllerBase
    {
        private readonly IProdutoService _produtoService;

        public ProdutosController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpGet("skip/{skip:int}/take/{take:int}")]
        public async Task<ActionResult> GetAll([FromQuery] ProdutoParameters parameters,
            int skip = 0, int take = 5)
        {
            try
            {
                if (!parameters.DataFabricacaoValida()) 
                    return BadRequest(new ErrorResponse("A data de fabricação máxima não pode ser menor que a data mínima "));

                if (!parameters.DataValidadeValida())
                    return BadRequest(new ErrorResponse("A data de validade máxima não pode ser menor que a data mínima "));

                var result = (await _produtoService.GetAllAsync(parameters, skip, take)).ToList();

                return Ok(
                    new PagedResponse<List<ProdutoDto>>(
                        result,
                        skip,
                        take,
                        result.Count())
                );
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, new ErrorResponse(ex.Message));
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> GetById(int id)
        {
            try
            {
                var produto = await _produtoService.GetByIdAsync(id);

                if (produto == null)
                    return NotFound(new ErrorResponse("Produto não encontrado."));

                return Ok(
                    new SuccessResponse<ProdutoDto>(produto));
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, new ErrorResponse(ex.Message));
            }
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] ProdutoDtoCreate produto)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest();

                await _produtoService.AddAsync(produto);

                return StatusCode(
                    201,
                    new SuccessResponse<ProdutoDtoCreate>(
                        produto,
                        "Produto criado com sucesso.")
                );
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, new ErrorResponse(ex.Message));
            }
        }

        [HttpPut]
        public async Task<ActionResult> Update([FromBody] ProdutoDtoUpdate produto)
        {
            try
            {
                if (!await _produtoService.ExistAsync(produto.Codigo))
                    return NotFound(new ErrorResponse("Produto não encontrado."));

                if (!ModelState.IsValid)
                    return BadRequest();

                await _produtoService.UpdateAsync(produto);

                return Ok(new SuccessResponse<ProdutoDtoUpdate>(
                            produto,
                            "Produto alterado com sucesso.")
                );
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, new ErrorResponse(ex.Message));
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                if (!await _produtoService.ExistAsync(id))
                    return NotFound(new ErrorResponse("Produto não encontrado."));

                await _produtoService.RemoveAsync(id);

                return Ok(
                    new SuccessResponse<object>(null, "Produto deletado com sucesso.")
                );
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, new ErrorResponse(ex.Message));
            }
        }
    }
}
