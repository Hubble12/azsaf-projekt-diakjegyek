-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2026. Feb 03. 09:35
-- Kiszolgáló verziója: 10.4.32-MariaDB
-- PHP verzió: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `11adiakok`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `diakokjegyek12data`
--

CREATE TABLE `diakokjegyek12data` (
  `1` int(2) DEFAULT NULL,
  `Paddie` varchar(9) DEFAULT NULL,
  `4.01` decimal(3,2) DEFAULT NULL,
  `2.85` decimal(3,2) DEFAULT NULL,
  `3.09` decimal(3,2) DEFAULT NULL,
  `2.99` decimal(3,2) DEFAULT NULL,
  `4.31` decimal(3,2) DEFAULT NULL,
  `2.4` decimal(3,2) DEFAULT NULL,
  `4.18` decimal(3,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- A tábla adatainak kiíratása `diakokjegyek12data`
--

INSERT INTO `diakokjegyek12data` (`1`, `Paddie`, `4.01`, `2.85`, `3.09`, `2.99`, `4.31`, `2.4`, `4.18`) VALUES
(2, 'Erie', 4.13, 1.45, 1.32, 1.89, 2.44, 2.56, 4.98),
(3, 'Debora', 2.41, 1.26, 3.54, 3.58, 4.37, 3.16, 1.31),
(4, 'Mychal', 3.70, 4.34, 4.32, 4.36, 4.57, 3.58, 4.72),
(5, 'Zachariah', 3.22, 3.24, 2.62, 2.47, 4.25, 4.02, 1.15),
(6, 'Chrisse', 2.77, 2.07, 3.86, 4.38, 2.76, 4.81, 3.77),
(7, 'Alvy', 4.76, 4.00, 3.35, 1.24, 1.08, 1.00, 1.52),
(8, 'Miran', 4.25, 1.14, 2.89, 1.91, 3.17, 3.63, 1.62),
(9, 'Granville', 1.44, 3.98, 1.03, 1.47, 4.14, 3.92, 3.96),
(10, 'Sim', 4.94, 4.36, 4.15, 4.12, 4.99, 1.20, 2.60),
(11, 'Ambrosius', 1.67, 3.27, 1.80, 4.70, 2.38, 2.11, 1.75),
(12, 'Tamar', 2.84, 3.52, 3.66, 1.79, 3.45, 3.95, 4.82),
(13, 'Saundra', 2.99, 4.09, 4.65, 1.51, 4.32, 1.51, 4.96),
(14, 'Jewell', 2.90, 1.31, 2.22, 4.11, 3.07, 2.27, 4.86),
(15, 'Adams', 4.76, 2.02, 1.91, 4.59, 2.46, 1.44, 3.01),
(16, 'Clemence', 4.03, 2.16, 2.90, 4.75, 3.05, 2.66, 2.29),
(17, 'Bondie', 4.21, 3.66, 2.76, 2.43, 2.35, 3.02, 1.87),
(18, 'Hamish', 4.90, 1.51, 2.83, 3.00, 2.90, 4.43, 2.18),
(19, 'Ingra', 3.09, 4.31, 1.25, 3.57, 3.43, 1.19, 3.52),
(20, 'Niel', 1.91, 3.73, 1.43, 4.83, 1.79, 1.93, 4.32),
(21, 'Serge', 4.57, 3.80, 4.91, 2.17, 4.60, 1.90, 2.81),
(22, 'Penn', 4.22, 2.00, 4.30, 2.74, 2.79, 1.36, 3.58),
(23, 'Hetty', 1.29, 3.11, 1.26, 1.09, 1.34, 1.77, 3.57),
(24, 'Maye', 4.58, 3.08, 3.03, 2.87, 4.04, 3.45, 2.36),
(25, 'Kermy', 4.52, 4.75, 3.92, 4.49, 4.49, 1.57, 2.57),
(26, 'Goldina', 4.38, 4.30, 4.11, 2.25, 1.29, 4.10, 4.65),
(27, 'Urbanus', 1.78, 1.81, 1.24, 4.07, 4.43, 4.19, 2.04),
(28, 'Parker', 4.00, 4.81, 1.64, 4.98, 3.77, 2.08, 2.67),
(29, 'Sayre', 2.84, 1.83, 4.31, 1.26, 3.58, 2.49, 4.50),
(30, 'Fonzie', 1.69, 2.89, 2.62, 4.20, 2.80, 2.08, 4.48);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
