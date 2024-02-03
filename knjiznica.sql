-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Feb 03, 2024 at 11:14 AM
-- Server version: 8.0.31
-- PHP Version: 8.0.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `knjiznica`
--

-- --------------------------------------------------------

--
-- Table structure for table `gradja`
--

DROP TABLE IF EXISTS `gradja`;
CREATE TABLE IF NOT EXISTS `gradja` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Naziv` varchar(40) COLLATE utf32_croatian_ci NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=utf32 COLLATE=utf32_croatian_ci;

--
-- Dumping data for table `gradja`
--

INSERT INTO `gradja` (`ID`, `Naziv`) VALUES
(1, 'knjiga'),
(2, 'članak'),
(3, 'časopis'),
(4, 'kartografska građa'),
(5, 'novine');

-- --------------------------------------------------------

--
-- Table structure for table `jezik_izdanja`
--

DROP TABLE IF EXISTS `jezik_izdanja`;
CREATE TABLE IF NOT EXISTS `jezik_izdanja` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Jezik` varchar(20) COLLATE utf32_croatian_ci NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=utf32 COLLATE=utf32_croatian_ci;

--
-- Dumping data for table `jezik_izdanja`
--

INSERT INTO `jezik_izdanja` (`ID`, `Jezik`) VALUES
(1, 'hrvatski'),
(2, 'engleski'),
(3, 'njemački'),
(4, 'talijanski'),
(5, 'francuski');

-- --------------------------------------------------------

--
-- Table structure for table `kategorija`
--

DROP TABLE IF EXISTS `kategorija`;
CREATE TABLE IF NOT EXISTS `kategorija` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Naziv` varchar(40) COLLATE utf32_croatian_ci NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=16 DEFAULT CHARSET=utf32 COLLATE=utf32_croatian_ci;

--
-- Dumping data for table `kategorija`
--

INSERT INTO `kategorija` (`ID`, `Naziv`) VALUES
(1, 'povijesni roman'),
(2, 'ljubavni roman'),
(3, 'triler'),
(4, 'fantasy'),
(5, 'znanstvena fantastika'),
(6, 'klasik'),
(7, 'poezija'),
(8, 'kriminalistički roman'),
(9, 'publicistika'),
(10, 'atlasi i karte'),
(11, 'znanstveni rad'),
(12, 'novinski rad'),
(13, 'memoari'),
(14, 'periodika'),
(15, 'zbirka priča');

-- --------------------------------------------------------

--
-- Table structure for table `knjiga`
--

DROP TABLE IF EXISTS `knjiga`;
CREATE TABLE IF NOT EXISTS `knjiga` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Naslov` varchar(50) COLLATE utf32_croatian_ci NOT NULL,
  `Autor` varchar(50) COLLATE utf32_croatian_ci NOT NULL,
  `Mjesto_izdavanja` varchar(20) COLLATE utf32_croatian_ci NOT NULL,
  `Izdavac` varchar(30) COLLATE utf32_croatian_ci NOT NULL,
  `ID_jezik` int DEFAULT NULL,
  `ID_gradja` int DEFAULT NULL,
  `ID_kategorija` int NOT NULL,
  `Kolicina` int UNSIGNED NOT NULL,
  `Dostupnost` tinyint(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`ID`),
  KEY `ID_kategorija` (`ID_kategorija`),
  KEY `ID_tip` (`ID_gradja`),
  KEY `ID_jezik` (`ID_jezik`)
) ENGINE=MyISAM AUTO_INCREMENT=22 DEFAULT CHARSET=utf32 COLLATE=utf32_croatian_ci;

--
-- Dumping data for table `knjiga`
--

INSERT INTO `knjiga` (`ID`, `Naslov`, `Autor`, `Mjesto_izdavanja`, `Izdavac`, `ID_jezik`, `ID_gradja`, `ID_kategorija`, `Kolicina`, `Dostupnost`) VALUES
(1, 'Bračni portret', 'Maggie O\'Farrell', 'Zagreb', 'Profil', 1, 1, 1, 5, 1),
(2, 'North and South', 'Elizabeth Gaskell', 'London', 'Macmillan Publishers', 2, 1, 1, 4, 1),
(3, 'L\'abito da sposa', 'Danielle Steel', 'Milano', 'Sperling & Kupfer', 4, 1, 2, 8, 1),
(4, 'Jedan dan', 'David Nicholls', 'Zagreb', 'Znanje', 1, 1, 2, 13, 1),
(5, 'Flug 416', 'T.J Newman', 'Stuttgart', 'Zeitfracht GMBH', 3, 1, 3, 9, 1),
(6, 'Gone Girl', 'Gillian Flynn', 'London', 'Hachette UK', 2, 1, 3, 3, 1),
(7, 'Posljednja želja', 'Andrzej Sapkowski', 'Zagreb', 'Egmont', 1, 1, 4, 0, 0),
(8, 'Hurinova djeca', 'J. R. R. Tolkien', 'Zagreb', 'Školska knjiga', 1, 1, 4, 11, 1),
(9, 'Dune - Der Wüstenplanet', 'Frank Herbert', 'Stuttgart', 'Zeitfracht GMBH', 3, 1, 5, 0, 0),
(10, 'Nemam usta, a moram vrištati', 'Harlan Ellison', 'Zagreb', 'Zagrebačka naklada', 1, 1, 5, 13, 1),
(11, 'Die Verwandlung', 'Franz Kafka', 'Stuttgart', 'Zeitfracht GMBH', 3, 1, 6, 8, 1),
(12, 'Der Vorleser', 'Bernhard Schlink', 'Stuttgart', 'Zeitfracht GMBH', 3, 1, 5, 14, 1),
(13, 'Journal de guerre', 'Paul Morand', 'Pariz', 'Gallimard', 5, 1, 13, 1, 1),
(14, 'Atlas Europe', 'Denis Šehić', 'Zagreb', 'Europapress holding', 1, 4, 10, 2, 0),
(16, 'Lupus in elegia', 'Peter Kasza', 'Split', 'Književni krug Split', 2, 2, 11, 3, 1),
(17, 'Zbornik za narodni život i običaje Južnih Slavena', 'Ivan Milčetić et al.', 'Zagreb', 'JAZU', 1, 3, 14, 12, 0),
(18, 'L\'occupation', 'Annie Ernaux', 'Pariz', 'Gallimard', 5, 1, 15, 6, 1),
(19, 'If This Is a Man', 'Primo Levi', 'New York', 'The Orion Press', 2, 1, 13, 3, 1),
(20, 'The Devil Takes You Home', 'Gabino Iglesias', 'Boston', 'Mulholland Books', 2, 1, 3, 9, 1),
(21, 'Geneva', 'Richard Armitage', 'London', 'Faber & Faber', 2, 1, 3, 7, 1);

-- --------------------------------------------------------

--
-- Table structure for table `korisnik`
--

DROP TABLE IF EXISTS `korisnik`;
CREATE TABLE IF NOT EXISTS `korisnik` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Korisnicko_ime` varchar(20) COLLATE utf32_croatian_ci NOT NULL,
  `Lozinka` varchar(50) COLLATE utf32_croatian_ci NOT NULL,
  `Ime` varchar(30) COLLATE utf32_croatian_ci NOT NULL,
  `Prezime` varchar(30) COLLATE utf32_croatian_ci NOT NULL,
  `Email` varchar(30) CHARACTER SET utf32 COLLATE utf32_croatian_ci NOT NULL,
  `Datum_clanarine` datetime NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=14 DEFAULT CHARSET=utf32 COLLATE=utf32_croatian_ci;

--
-- Dumping data for table `korisnik`
--

INSERT INTO `korisnik` (`ID`, `Korisnicko_ime`, `Lozinka`, `Ime`, `Prezime`, `Email`, `Datum_clanarine`) VALUES
(1, 'prvi', 'lozinka', 'John', 'Doe', 'jdoe@gmail.com', '2021-12-01 00:00:00'),
(2, 'korisnik1', '12345', 'Ivan', 'Horvat', 'korisnik1@example.com', '2019-08-13 00:00:00'),
(3, 'user1', 'password', 'Petra', 'Novak', 'petra.novak@example.net', '2020-07-14 00:00:00'),
(4, 'korisnik2', 'qwertz', 'Marko', 'Herceg', 'moj_email@example.hr', '2023-11-05 00:00:00'),
(5, 'user2', 'abcde', 'Ana', 'Sever', 'kontakt@example.org', '2022-08-30 00:00:00'),
(6, 'korisnik3', '123456789', 'Maja', 'Kralj', 'kraljica@example.org', '2022-07-21 00:00:00'),
(7, 'user3', '987654321', 'Ivana', 'Varga', 'vargai@example.net', '2017-01-25 00:00:00'),
(8, 'admin1', 'password', 'Jane', 'Doe', 'jane.doe@gmail.com', '0000-00-00 00:00:00'),
(9, 'admin2', 'abc123', 'Zoran', 'Kovačević', 'admin2@example.hr', '0000-00-00 00:00:00'),
(10, 'admin3', '111111', 'Ivica', 'Babić', 'admin3@example.com', '0000-00-00 00:00:00'),
(11, 'admin4', 'sunshine', 'Josip', 'Marić', 'admin4@example.net', '0000-00-00 00:00:00'),
(12, 'admin5', '54321', 'Mate', 'Jurić', 'admin5@example.org', '0000-00-00 00:00:00'),
(13, 'admin6', 'iloveyou', 'Katarina', 'Vuković', 'admin7@example.com', '0000-00-00 00:00:00');

-- --------------------------------------------------------

--
-- Table structure for table `korisnik_prava`
--

DROP TABLE IF EXISTS `korisnik_prava`;
CREATE TABLE IF NOT EXISTS `korisnik_prava` (
  `ID_korisnik` int NOT NULL,
  `ID_pravo` int NOT NULL,
  KEY `ID_korisnik` (`ID_korisnik`),
  KEY `ID_pravo` (`ID_pravo`)
) ENGINE=MyISAM DEFAULT CHARSET=utf32 COLLATE=utf32_croatian_ci;

--
-- Dumping data for table `korisnik_prava`
--

INSERT INTO `korisnik_prava` (`ID_korisnik`, `ID_pravo`) VALUES
(1, 2),
(2, 2),
(3, 2),
(4, 2),
(5, 2),
(6, 2),
(7, 2),
(8, 1),
(9, 1),
(10, 1),
(11, 1),
(12, 1),
(13, 1);

-- --------------------------------------------------------

--
-- Table structure for table `pravo`
--

DROP TABLE IF EXISTS `pravo`;
CREATE TABLE IF NOT EXISTS `pravo` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Naziv` varchar(30) COLLATE utf32_croatian_ci NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf32 COLLATE=utf32_croatian_ci;

--
-- Dumping data for table `pravo`
--

INSERT INTO `pravo` (`ID`, `Naziv`) VALUES
(1, 'Administrator'),
(2, 'Korisnik');

-- --------------------------------------------------------

--
-- Table structure for table `rezervacija`
--

DROP TABLE IF EXISTS `rezervacija`;
CREATE TABLE IF NOT EXISTS `rezervacija` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `ID_knjige` int NOT NULL,
  `ID_korisnika` int NOT NULL,
  `Datum_posudbe` date NOT NULL,
  `Datum_vracanja` date NOT NULL,
  `ID_status` int NOT NULL DEFAULT '1',
  PRIMARY KEY (`ID`),
  KEY `ID_knjige` (`ID_knjige`),
  KEY `ID_korisnika` (`ID_korisnika`),
  KEY `FK_Status_ID` (`ID_status`)
) ENGINE=MyISAM AUTO_INCREMENT=13 DEFAULT CHARSET=utf32 COLLATE=utf32_croatian_ci;

--
-- Dumping data for table `rezervacija`
--

INSERT INTO `rezervacija` (`ID`, `ID_knjige`, `ID_korisnika`, `Datum_posudbe`, `Datum_vracanja`, `ID_status`) VALUES
(2, 13, 1, '2024-01-30', '2024-02-06', 1),
(7, 12, 1, '2024-01-30', '2024-02-06', 2),
(6, 4, 1, '2024-01-30', '2024-02-06', 2),
(8, 7, 1, '2024-01-30', '2024-02-06', 1),
(9, 10, 7, '2024-02-01', '2024-02-08', 1),
(10, 8, 5, '2024-02-02', '2024-02-09', 1),
(11, 10, 5, '2024-02-02', '2024-02-09', 1),
(12, 5, 1, '2024-02-03', '2024-02-10', 1);

-- --------------------------------------------------------

--
-- Table structure for table `status_rezervacije`
--

DROP TABLE IF EXISTS `status_rezervacije`;
CREATE TABLE IF NOT EXISTS `status_rezervacije` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Naziv` varchar(20) COLLATE utf32_croatian_ci NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf32 COLLATE=utf32_croatian_ci;

--
-- Dumping data for table `status_rezervacije`
--

INSERT INTO `status_rezervacije` (`ID`, `Naziv`) VALUES
(1, 'Posudjeno'),
(2, 'Vraceno');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
