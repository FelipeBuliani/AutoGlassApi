using AutoGlassApi.Domain.Entities;
using AutoGlassApi.Domain.Entities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace AutoGlassApi.Infra.Data.Mappings
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produto");

            builder.HasKey(p => p.Codigo);

            builder.Property(p => p.Descricao).HasMaxLength(50).IsRequired();

            builder.Property(p => p.Situacao).HasMaxLength(10);

            builder.Property(p => p.DataFabricacao);
            builder.HasIndex(p => p.DataFabricacao);

            builder.Property(p => p.DataValidade);

            builder.Property(p => p.CodigoFornecedor);
            builder.Property(p => p.DescricaoFornecedor).HasMaxLength(50);
            builder.Property(p => p.CnpjFornecedor).HasMaxLength(20);

            builder.HasData(
                new Produto
                {
                    Codigo = 1,
                    Descricao = "Vidro",
                    Situacao = SituacaoProduto.Ativo,
                    DataFabricacao = new DateTime(2023, 01, 29, 15, 8, 0),
                    DataValidade = new DateTime(2028, 01, 1, 18, 0, 0),
                    CodigoFornecedor = 1,
                    DescricaoFornecedor = "Fornecedor 1",
                    CnpjFornecedor = "12.983.451/0001-01"
                },
                new Produto
                {
                    Codigo = 2,
                    Descricao = "Retrovisor",
                    Situacao = SituacaoProduto.Ativo,
                    DataFabricacao = new DateTime(2022, 11, 18, 9, 55, 18),
                    DataValidade = new DateTime(2026, 11, 30, 08, 0, 0),
                    CodigoFornecedor = 1,
                    DescricaoFornecedor = "Fornecedor 1",
                    CnpjFornecedor = "12.983.451/0001-01"
                },
                new Produto
                {
                    Codigo = 3,
                    Descricao = "Pelicula",
                    Situacao = SituacaoProduto.Inativo,
                    DataFabricacao = new DateTime(2019, 10, 22, 8, 45, 23),
                    DataValidade = new DateTime(2030, 10, 22, 8, 45, 23),
                    CodigoFornecedor = 1,
                    DescricaoFornecedor = "Fornecedor 1",
                    CnpjFornecedor = "12.983.451/0001-01"
                },
                new Produto
                {
                    Codigo = 4,
                    Descricao = "Lanterna",
                    Situacao = SituacaoProduto.Ativo,
                    DataFabricacao = new DateTime(2022, 12, 13, 12, 42, 56),
                    DataValidade = new DateTime(2024, 10, 1, 19, 30, 0),
                    CodigoFornecedor = 2,
                    DescricaoFornecedor = "Fornecedor 2",
                    CnpjFornecedor = "45.781.394/0001-02"
                },
                new Produto
                {
                    Codigo = 5,
                    Descricao = "Lampada",
                    Situacao = SituacaoProduto.Ativo,
                    DataFabricacao = new DateTime(2023, 2, 22, 9, 15, 32),
                    DataValidade = new DateTime(2025, 2, 22, 9, 15, 32),
                    CodigoFornecedor = 2,
                    DescricaoFornecedor = "Fornecedor 2",
                    CnpjFornecedor = "45.781.394/0001-02"
                },
                new Produto
                {
                    Codigo = 6,
                    Descricao = "Farol",
                    Situacao = SituacaoProduto.Ativo,
                    DataFabricacao = new DateTime(2021, 8, 7, 14, 24, 35),
                    DataValidade = new DateTime(2023, 8, 20, 14, 20, 0),
                    CodigoFornecedor = 2,
                    DescricaoFornecedor = "Fornecedor 2",
                    CnpjFornecedor = "45.781.394/0001-02"
                },
                new Produto
                {
                    Codigo = 7,
                    Descricao = "Higienizacao",
                    Situacao = SituacaoProduto.Inativo,
                    DataFabricacao = new DateTime(2023, 01, 15, 9, 37, 0),
                    DataValidade = new DateTime(2023, 04, 15, 0, 0, 0),
                    CodigoFornecedor = 2,
                    DescricaoFornecedor = "Fornecedor 2",
                    CnpjFornecedor = "45.781.394/0001-02"
                },
                new Produto
                {
                    Codigo = 8,
                    Descricao = "Para-choque",
                    Situacao = SituacaoProduto.Ativo,
                    DataFabricacao = new DateTime(2022, 7, 8, 18, 15, 17),
                    DataValidade = new DateTime(2032, 7, 1, 7, 0, 0),
                    CodigoFornecedor = 3,
                    DescricaoFornecedor = "Fornecedor 3",
                    CnpjFornecedor = "55.425.738/0001-47"
                },
                new Produto
                {
                    Codigo = 9,
                    Descricao = "Lataria",
                    Situacao = SituacaoProduto.Inativo,
                    DataFabricacao = new DateTime(2023, 03, 2, 11, 18, 0),
                    DataValidade = new DateTime(2025, 9, 1, 19, 0, 0),
                    CodigoFornecedor = 3,
                    DescricaoFornecedor = "Fornecedor 3",
                    CnpjFornecedor = "55.425.738/0001-47"
                },
                new Produto
                {
                    Codigo = 10,
                    Descricao = "Suspensao",
                    Situacao = SituacaoProduto.Ativo,
                    DataFabricacao = new DateTime(2022, 12, 31, 15, 32, 15),
                    DataValidade = new DateTime(2025, 12, 31, 15, 32, 15),
                    CodigoFornecedor = 3,
                    DescricaoFornecedor = "Fornecedor 3",
                    CnpjFornecedor = "55.425.738/0001-47"
                },
                new Produto
                {
                    Codigo = 11,
                    Descricao = "Palheta",
                    Situacao = SituacaoProduto.Ativo,
                    DataFabricacao = new DateTime(2021, 5, 30, 11, 40, 45),
                    DataValidade = new DateTime(2024, 5, 30, 11, 40, 45),
                    CodigoFornecedor = 3,
                    DescricaoFornecedor = "Fornecedor 3",
                    CnpjFornecedor = "55.425.738/0001-47"
                }
            );
        }
    }
}
