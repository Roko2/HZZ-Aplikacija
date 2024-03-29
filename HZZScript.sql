USE [STUDENTI_PIN]
GO
/****** Object:  Table [dbo].[Kovac_Categories]    Script Date: 20.12.2022. 20:15:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kovac_Categories](
	[ID] [int] NOT NULL,
	[Description] [varchar](100) NULL,
	[Url] [varchar](50) NULL,
	[DatumDodavanja] [nvarchar](100) NULL,
 CONSTRAINT [PK_Kovac_Categories] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kovac_Jobs]    Script Date: 20.12.2022. 20:15:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kovac_Jobs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Naziv] [varchar](200) NULL,
	[Datum] [nvarchar](100) NULL,
	[Opis] [varchar](1000) NULL,
	[Link] [varchar](200) NULL,
 CONSTRAINT [PK_Kovac_Jobs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Kovac_Categories] ([ID], [Description], [Url], [DatumDodavanja]) VALUES (6, N'Uredski i šalterski službenici', N'http://burzarada.hzz.hr/rss/rsskat1011.xml', N'7.2.2021.')
INSERT [dbo].[Kovac_Categories] ([ID], [Description], [Url], [DatumDodavanja]) VALUES (7, N'Moja kategorija', N'http://burzarada.hzz.hr/rss/rsskat1012.xml', N'17.4.2021.')
INSERT [dbo].[Kovac_Categories] ([ID], [Description], [Url], [DatumDodavanja]) VALUES (12, N'Tiskari, precizni mehaničari, keramičari i staklar', N'http://burzarada.hzz.hr/rss/rsskat1017.xml', N'10.2.2021.')
INSERT [dbo].[Kovac_Categories] ([ID], [Description], [Url], [DatumDodavanja]) VALUES (18, N'Jednostavna građevinska, proizvodna i transportna zanimanja', N'http://burzarada.hzz.hr/rss/rsskat1024.xml', N'20.3.2021.')
GO
SET IDENTITY_INSERT [dbo].[Kovac_Jobs] ON 

INSERT [dbo].[Kovac_Jobs] ([Id], [Naziv], [Datum], [Opis], [Link]) VALUES (5, N'NASLOVNI DOCENT/ICA - TEOLOGIJA', N'13.1.2021.', N'Opis posla: <P>OPIS POSLOVA ODREĐEN JE ČLANKOM 71, REDNI BROJ 16. PRAVILNIKA O USTROJU I O RADU HRVATSKOG KATOLIČKOG SVEUČILIŠTA</P>

<P>HRVATSKO KATOLIČKO SVEUČILIŠTE</P>

<P>ILICA 242</P>

<P>10000 ZAGREB</P>

<P>&amp;amp;NBSP;</P>

<P>HRVATSKO KATOLIČKO SVEUČILIŠTE RASPISUJE</P>

<P>&amp;amp;NBSP;</P>

<P>N A T J E Č A J</P>

<P>&amp;amp;NBSP;</P>

<P>1. ZA IZBOR JEDNOG NASTAVNIKA U NASLOVNO ZNANSTVENO-NASTAVNO ZVANJE IZVANREDNI PROFESOR BEZ ZASNIVANJA RADNOG ODNOSA U ZNANSTVENOM PODRUČ', N'http://burzarada.hzz.hr/RadnoMjesto_Ispis.aspx?WebSifra=110809636')
INSERT [dbo].[Kovac_Jobs] ([Id], [Naziv], [Datum], [Opis], [Link]) VALUES (6, N'NASTAVNIK/ICA FIZIKE', N'1.2.2021.', N'Opis posla: <P>NASTAVNIK/ICA FIZIKE</P>
, Kategorija: PROFESORI, NASTAVNICI I STRUČNJACI ZA OBRAZOVANJE, Rok za prijavu: 10.02.2021, Mjesto rada: ZAGREB, Općina: GRAD ZAGREB, Županija: GRAD ZAGREB', N'http://burzarada.hzz.hr/RadnoMjesto_Ispis.aspx?WebSifra=111172662')
INSERT [dbo].[Kovac_Jobs] ([Id], [Naziv], [Datum], [Opis], [Link]) VALUES (7, N'ARMIRAČ/ARMIRAČICA', N'4.12.2020.', N'Opis posla: <P><STRONG>DEFINICIJA POSLA: </STRONG></P>

<UL>
	<LI>IZRAĐUJE I POSTAVLJA OPLATU BETONSKE KUPOLE KRUŽNOG, ELIPSASTOG I PARABOLIČNOG OBLIKA U VERTIKALNOM&amp;amp;AMP;NBSP; PRESJEKU;</LI>
	<LI>IZRAĐUJE CRTEŽE DRVENIH KROVNIH KONSTRUKCIJA;</LI>
	<LI>IZRAĐUJE REŠETKASTE OKVIRE KROVNIH NOSAČA I CRTA PROFILE NOSAČA;</LI>
	<LI>IZRAĐUJE ZAVOJITE DRVENE STEPENICE, TE VRLO LUKSUZNE STEPENICE S OGRADOM;</LI>
	<LI>IZRAĐUJE NANOSNU SKELU, VRŠI RAZMJERAVANJE KARAKTERISTIČNIH TOČAKA OBJEKTA NA SKELI, T', N'http://burzarada.hzz.hr/RadnoMjesto_Ispis.aspx?WebSifra=110410056')
INSERT [dbo].[Kovac_Jobs] ([Id], [Naziv], [Datum], [Opis], [Link]) VALUES (8, N'.NET DEVELOPER/DEVELOPERKA', N'30.11.2020.', N'Opis posla: <P>.NET DEVELOPER DIZAJNIRA I RAZVIJA DESKTOP I WEB PROGRAMSKA RJEŠENJA TEMELJENA NA MICROSOFTOVIM TEHNOLOGIJAMA. USMJEREN JE NA ANALIZU SPECIFIČNIH POSLOVNIH ZAHTIJEVA KLIJENTA I IZRADU ODGOVARAJUĆIH RJEŠENJA.&amp;amp;AMP;NBSP;<BR />
KONKRETNO SE RADI NA KONTINUIRANOM RAZVOJU COMPAKOVIH PROGRAMSKIH RJEŠENJA UZ KORIŠTENJE&amp;amp;AMP;NBSP;NAJNOVIJIH&amp;amp;AMP;NBSP;RAZVOJNIH&amp;amp;AMP;NBSP;ALATA I KOMPONENTI (VISUAL STUDIO 2019, DEVEXPRESS KOMPONENTE I SL.).<BR />
TAKOĐER, RADI SE I S NEKIM', N'http://burzarada.hzz.hr/RadnoMjesto_Ispis.aspx?WebSifra=110323424')
INSERT [dbo].[Kovac_Jobs] ([Id], [Naziv], [Datum], [Opis], [Link]) VALUES (10, N'OPERATER/OPERATERKA U TVORNICI HUMUSA', N'13.11.2021.', N'Javit se 15.12.2021.', N'http://burzarada.hzz.hr/RadnoMjesto_Ispis.aspx?WebSifra=114964439')
SET IDENTITY_INSERT [dbo].[Kovac_Jobs] OFF
GO
