CREATE TABLE [dbo].[Proizvodjac] (
    [ID]           INT           NOT NULL,
    [Naziv]        VARCHAR (255) NOT NULL,
    [BrojTelefona] VARCHAR (255) NULL,
    [Adresa]       VARCHAR (255) NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

CREATE TABLE [dbo].[Proizvod] (
    [ProizvodID]          INT         NOT NULL,
    [Naziv]               NCHAR (25)  NOT NULL,
    [Karakteristike]      NCHAR (150) NULL,
    [Model]               NCHAR (35)  NULL,
    [Cena]                FLOAT (53)  NOT NULL,
    [RaspolozivaKolicina] INT         NOT NULL,
    [ProizvodjacID]       INT         NOT NULL,
    PRIMARY KEY CLUSTERED ([ProizvodID] ASC),
    FOREIGN KEY ([ProizvodjacID]) REFERENCES [dbo].[Proizvodjac] ([ID])
);

CREATE TABLE [dbo].[Osoba] (
    [OsobaId]        INT           NOT NULL,
    [Ime]            VARCHAR (255) DEFAULT (NULL) NULL,
    [Prezime]        VARCHAR (255) DEFAULT (NULL) NULL,
    [KontaktTelefon] VARCHAR (15)  DEFAULT (NULL) NULL,
    [Email]          VARCHAR (50)  DEFAULT (NULL) NOT NULL,
    [Adresa]         VARCHAR (255) DEFAULT (NULL) NULL,
    PRIMARY KEY CLUSTERED ([OsobaId] ASC)
);

CREATE TABLE [dbo].[Zaposleni] (
    [ID]            INT          NOT NULL,
    [KorisnickoIme] VARCHAR (20) DEFAULT (NULL) NULL,
    [Sifra]         VARCHAR (20) DEFAULT (NULL) NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Zaposleni_Clan] FOREIGN KEY ([ID]) REFERENCES [dbo].[Osoba] ([OsobaId])
);

CREATE TABLE [dbo].[Clan] (
    [ClanskiBroj] INT NOT NULL,
    [OsobaId]     INT NOT NULL,
    PRIMARY KEY CLUSTERED ([OsobaId] ASC),
    CONSTRAINT [FK_Osoba_Clan] FOREIGN KEY ([OsobaId]) REFERENCES [dbo].[Osoba] ([OsobaId])
);

CREATE TABLE [dbo].[Narudzbenica] (
    [SifraNarudzbenice] INT             IDENTITY (1, 1) NOT NULL,
    [DatumOd]           DATETIME        NOT NULL,
    [DatumDo]           DATETIME        NOT NULL,
    [UkupanIznos]       DECIMAL (18, 3) NOT NULL,
    [SifraClana]        INT             NOT NULL,
    PRIMARY KEY CLUSTERED ([SifraNarudzbenice] ASC),
    CONSTRAINT [FK_Narudzbenica_Clan] FOREIGN KEY ([SifraClana]) REFERENCES [dbo].[Clan] ([OsobaId])
);

CREATE TABLE [dbo].[StavkaNarudzbenice] (
    [ID]        INT NOT NULL,
    [RedniBroj] INT NOT NULL,
    [Kolicina]  INT NOT NULL,
    [Proizvod]  INT NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC, [RedniBroj] ASC),
    CONSTRAINT [FK_StavkaNarudzbenice_Proizvod] FOREIGN KEY ([Proizvod]) REFERENCES [dbo].[Proizvod] ([ProizvodID]),
    CONSTRAINT [FK_StavkaNarudzbenice_Narudzbenica] FOREIGN KEY ([ID]) REFERENCES [dbo].[Narudzbenica] ([SifraNarudzbenice])
);

INSERT INTO [dbo].[Zaposleni] ([ID], [KorisnickoIme], [Sifra]) VALUES (1, N'k1', N'k1')
INSERT INTO [dbo].[Osoba] ([OsobaId], [Ime], [Prezime], [KontaktTelefon], [Email], [Adresa]) VALUES (1, N'Milan', N'Doderovic', N'0645555555', N'md@gmail.com', N'Studenjak')
INSERT INTO [dbo].[Proizvodjac] ([ID], [Naziv], [BrojTelefona], [Adresa]) VALUES (1, N'Sony', N'222-555-222', N'Nemanjina')
INSERT INTO [dbo].[Proizvodjac] ([ID], [Naziv], [BrojTelefona], [Adresa]) VALUES (2, N'Nintendo', N'335-996-523', N'Hirosima')
INSERT INTO [dbo].[Proizvod] ([ProizvodID], [Naziv], [Karakteristike], [Model], [Cena], [RaspolozivaKolicina], [ProizvodjacID]) VALUES (1, N'PES 2020              ', N'Igrica                                                                                                                                               ', N'Fudbal                            ', 1, 44, 2)
