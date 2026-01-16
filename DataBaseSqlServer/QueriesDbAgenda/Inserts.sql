SELECT TOP (1000) [Id]
      ,[Nome]
      ,[Telefone]
      ,[Ativo]
  FROM [Agenda].[dbo].[Contatos]

INSERT INTO [Agenda].[dbo].[Contatos] ([Nome], [Telefone], [Ativo]) VALUES (N'Caio Bezerra', N'(11) 99999-9999', 1)
INSERT INTO [Agenda].[dbo].[Contatos] ([Nome], [Telefone], [Ativo]) VALUES (N'Maria Silva', N'(21) 98888-8888', 1)
INSERT INTO [Agenda].[dbo].[Contatos] ([Nome], [Telefone], [Ativo]) VALUES (N'João Souza', N'(31) 97777-7777', 0)
INSERT INTO [Agenda].[dbo].[Contatos] ([Nome], [Telefone], [Ativo]) VALUES (N'Ana Pereira', N'(41) 96666-6666', 1)
INSERT INTO [Agenda].[dbo].[Contatos] ([Nome], [Telefone], [Ativo]) VALUES (N'Carlos Oliveira', N'(51) 95555-5555', 0)