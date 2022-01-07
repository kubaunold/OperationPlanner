-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 07, 2022 at 04:38 PM
-- Server version: 10.4.22-MariaDB
-- PHP Version: 8.1.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `patient`
--

-- --------------------------------------------------------

--
-- Table structure for table `patient_table`
--

CREATE TABLE `patient_table` (
  `ID` int(11) NOT NULL,
  `Name` varchar(50) NOT NULL,
  `Age` float NOT NULL,
  `BMI` float NOT NULL,
  `Cancer` int(11) NOT NULL DEFAULT 0,
  `CVD` int(11) NOT NULL DEFAULT 0,
  `Dementia` int(11) NOT NULL DEFAULT 0,
  `Diabetes` int(11) NOT NULL DEFAULT 0,
  `Digestive` int(11) NOT NULL DEFAULT 0,
  `Osteoart` int(11) NOT NULL DEFAULT 0,
  `Psych` int(11) NOT NULL DEFAULT 0,
  `Pulmonary` int(11) NOT NULL DEFAULT 0,
  `Charlson` int(11) NOT NULL DEFAULT 0,
  `Mortality_rsi` float NOT NULL,
  `Complication_rsi` float NOT NULL,
  `Surgery_type` varchar(50) NOT NULL,
  `JUP_priority_predicted` int(11) NOT NULL DEFAULT 0,
  `JUP_priority_ideal` int(11) NOT NULL DEFAULT 0,
  `CreateAt` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `patient_table`
--

INSERT INTO `patient_table` (`ID`, `Name`, `Age`, `BMI`, `Cancer`, `CVD`, `Dementia`, `Diabetes`, `Digestive`, `Osteoart`, `Psych`, `Pulmonary`, `Charlson`, `Mortality_rsi`, `Complication_rsi`, `Surgery_type`, `JUP_priority_predicted`, `JUP_priority_ideal`, `CreateAt`) VALUES
(1, 'Nohi Dedyne', 67.8, 28.04, 0, 1, 0, 0, 1, 0, 0, 0, 0, -0.63, -0.26, '<Other>', 0, 10, '2022-01-03 15:33:31'),
(2, 'Ware Bimebu', 39.5, 37.85, 0, 1, 0, 0, 0, 0, 0, 0, 0, -0.63, -0.26, '<Other>', 0, 7, '2022-01-03 15:33:31'),
(3, 'Wuda Pijapi', 56.5, 19.56, 0, 0, 0, 0, 0, 0, 0, 0, 0, -0.49, 0, '<Other>', 0, 7, '2022-01-03 15:33:31'),
(4, 'Heha Myceho', 71, 32.22, 0, 1, 0, 0, 0, 0, 0, 0, 0, -1.38, -1.15, '<Other>', 0, 8, '2012-05-03 06:53:57'),
(5, 'Byxi Tawaty', 56.3, 24.32, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '<Other>', 0, 9, '2010-03-27 09:00:03'),
(6, 'Hica Vixevi', 57.7, 40.3, 0, 1, 0, 0, 0, 0, 1, 0, 0, -0.77, -0.84, '<Other>', 0, 10, '2003-12-06 12:56:30'),
(7, 'Nohi Dedyne', 67.8, 28.04, 0, 1, 0, 0, 1, 0, 0, 0, 0, -0.63, -0.26, '<Other>', 0, 10, '0000-00-00 00:00:00'),
(8, 'Kybe Gameru', 64.2, 43.2, 0, 1, 0, 0, 0, 0, 0, 0, 0, -0.64, 0.09, '<Other>', 0, 11, '2006-01-16 07:49:47'),
(9, 'Liho Ximefa', 66.2, 28.03, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0.02, 0.02, '<Other>', 0, 11, '2010-11-14 14:09:04'),
(10, 'Fose Sirepa', 20.1, 27.38, 1, 0, 0, 0, 0, 0, 0, 0, 2, 0.73, 0, '<Other>', 0, 8, '2002-02-18 15:21:30'),
(11, 'Goda Wyqypu', 48.8, 23.56, 0, 1, 0, 0, 0, 0, 0, 0, 0, -1.26, -1.2, '<Other>', 0, 5, '2004-01-18 09:40:39'),
(12, 'Franek Bak', 132, 34, 0, 0, 1, 1, 0, 0, 1, 1, 5, 2, 3, 'Flu', 15, 0, '2022-01-03 15:33:31'),
(13, 'errerer', 34, 45, 1, 1, 1, 0, 0, 0, 0, 0, 3, 1, 2, 'katar', 15, 0, '2022-01-07 09:45:15'),
(14, 'Mikolaj', 10, 20, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 'grypa', 3, 0, '2022-01-07 09:45:51'),
(15, 'Edward', 100, 50, 1, 1, 1, 1, 1, 1, 0, 0, 4, 1, 1, 'smierc', 19, 0, '2022-01-07 09:46:31'),
(16, 'jedenzrekordow', 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 3, 0, 0, 'niewiem', 1, 0, '2022-01-07 09:48:42'),
(17, 'jeszczeraz', 0, 25.77, 1, 0, 0, 0, 0, 0, 0, 1, 3, -1.34, 0.39, 'rrrr', 3, 0, '2022-01-07 09:49:28'),
(18, 'rrr', 0, 25.77, 1, 0, 0, 0, 0, 0, 0, 0, 0, -1.34, 0.39, 'fffffffffff', 2, 0, '2022-01-07 09:50:05'),
(19, 'eeee', 46, 25.77, 1, 0, 0, 0, 0, 0, 0, 1, 3, -1.34, 0.39, 'tttt', 12, 0, '2022-01-07 09:53:25'),
(20, 'Waldemar', 45.8, 28.77, 1, 0, 0, 0, 0, 0, 0, 1, 3, -1.34, 0.39, 'Kolano', 12, 13, '2022-01-07 09:57:57'),
(21, 'rere', 34, 34, 1, 1, 1, 1, 0, 0, 0, 0, 5, 2, 3, 'rrrrr', 21, 0, '2022-01-07 10:54:34'),
(22, 'Panu Ligevo', 62.1, 28.03, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0.16, -0.26, '<Other>', 0, 9, '2001-02-02 07:49:47'),
(23, 'Defi Nadovu', 52.2, 26.58, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0.3, 0, '<Other>', 0, 8, '2004-04-09 08:03:30'),
(24, 'Gepi Famyxe', 70.5, 50.47, 0, 1, 0, 0, 0, 0, 0, 0, 0, -0.36, -0.76, '<Other>', 0, 11, '2005-10-01 13:06:55'),
(25, 'Fyhi Tycaxa', 61.5, 29.53, 0, 1, 0, 0, 0, 0, 0, 0, 0, -0.58, 0.06, '<Other>', 0, 9, '2001-01-18 12:34:54'),
(26, 'Kifo Qoqiqy', 53.7, 39.06, 0, 1, 0, 1, 1, 0, 0, 0, 2, -1.42, -1.7, '<Other>', 0, 11, '2004-04-18 07:05:02'),
(27, 'Kefa Fuxyny', 56.5, 20, 1, 0, 0, 0, 0, 0, 0, 1, 1, -1.71, -0.37, '<Other>', 0, 8, '2009-12-31 10:06:52'),
(28, 'Byca Kakowy', 74.8, 35.45, 1, 1, 0, 0, 0, 0, 0, 0, 3, 0.1, 0, '<Other>', 0, 16, '2000-08-18 12:19:49'),
(29, 'Jemo Dohike', 74.1, 31.19, 1, 1, 0, 0, 0, 0, 0, 0, 9, -0.18, 0.26, '<Other>', 0, 21, '2004-10-01 10:14:41'),
(30, 'Franekd Bak', 132, 34, 0, 0, 1, 1, 0, 0, 1, 1, 5, 2, 3, 'Flu', 15, 0, '2022-01-03 15:33:31'),
(31, 'Franekde Bak', 132, 34, 0, 0, 1, 1, 0, 0, 1, 1, 5, 2, 3, 'Flu', 15, 0, '2022-01-03 15:33:31'),
(32, 'Marta Bak', 132, 34, 0, 0, 1, 1, 0, 0, 1, 1, 5, 2, 3, 'Flu', 15, 0, '2022-01-03 15:33:31'),
(33, 'Foqy Ruvivy', 57.1, 26.06, 0, 1, 0, 0, 1, 0, 0, 1, 1, -1.31, -0.31, '<Other>', 0, 10, '2007-09-24 14:35:37'),
(34, 'Xomu Tehiby', 37.9, 23.72, 1, 0, 0, 0, 0, 0, 1, 0, 8, -0.24, 0.63, '<Other>', 0, 16, '2013-03-15 08:22:36'),
(35, 'Fuly Paxegu', 18.1, 18.84, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0.62, 3.3, '<Other>', 0, 9, '2012-04-30 09:52:48'),
(36, 'Cuba Wyhegy', 85.1, 33.34, 1, 1, 0, 0, 0, 0, 0, 0, 2, 0.61, 2.38, '<Other>', 0, 18, '2005-07-20 11:46:34'),
(37, 'Sepy Jyjado', 68, 43.71, 1, 0, 0, 0, 0, 0, 0, 1, 3, -0.44, 3.12, '<Other>', 0, 18, '2002-06-24 14:10:42'),
(38, 'Xike Leniwe', 63.2, 29.04, 1, 0, 0, 0, 0, 0, 0, 0, 0, -0.73, 0.52, '<Other>', 0, 10, '2000-04-22 10:02:18'),
(39, 'Bavu Ruxipe', 67.4, 23.66, 1, 0, 0, 0, 0, 0, 1, 0, 8, 0.05, 0.41, '<Other>', 0, 19, '2004-05-13 09:56:24'),
(40, 'Dose Filyqu', 48.7, 29.4, 1, 0, 0, 0, 1, 0, 0, 1, 3, -0.2, 1.11, '<Other>', 0, 14, '2004-12-17 11:32:41'),
(41, 'Peto Cefery', 69.1, 32.98, 0, 1, 0, 0, 1, 0, 0, 1, 1, 0.79, 1.32, '<Other>', 0, 16, '2001-01-06 08:28:57'),
(42, 'Keso Sylili', 65, 24.05, 1, 0, 0, 0, 0, 0, 0, 0, 6, -0.19, 1.23, '<Other>', 0, 16, '2006-06-01 14:32:01'),
(43, 'Jedu Ladyle', 71.7, 28.38, 1, 1, 0, 0, 0, 0, 0, 0, 9, -0.56, 1.96, '<Other>', 0, 22, '2002-07-13 08:32:18'),
(44, 'Paly Ficawo', 45.1, 16.6, 0, 0, 0, 0, 0, 0, 0, 0, 2, -0.93, 0, '<Other>', 0, 7, '2012-09-11 06:00:23'),
(45, 'Ratu Sakyxi', 76.5, 30.86, 1, 1, 0, 0, 1, 0, 0, 0, 2, -0.62, 0.14, '<Other>', 0, 15, '2003-04-13 11:08:24'),
(46, 'Wice Laronu', 77.8, 35.87, 1, 1, 0, 0, 0, 0, 0, 0, 2, -0.48, 0.49, '<Other>', 0, 15, '2001-08-14 10:50:15'),
(47, 'Jyfy Dudabu', 62.5, 27.2, 1, 1, 0, 0, 0, 0, 0, 0, 8, -0.66, -0.26, '<Other>', 0, 18, '2005-07-08 08:23:57'),
(48, 'Lusi Bydylo', 61.8, 29.85, 1, 0, 0, 1, 0, 0, 0, 0, 3, -1.72, 0, '<Other>', 0, 12, '2005-10-29 10:30:40'),
(49, 'Vabu Nidily', 40.8, 17.92, 0, 0, 0, 0, 0, 0, 0, 0, 0, -0.82, 1.14, '<Other>', 0, 6, '2003-07-04 08:06:49'),
(50, 'Cijy Ceciva', 65.4, 35.85, 1, 1, 0, 0, 0, 0, 0, 1, 9, -2.3, -1.33, '<Other>', 0, 18, '2012-07-23 08:55:55'),
(51, 'Jely Dudiba', 79.5, 25.39, 1, 1, 0, 0, 0, 0, 0, 1, 7, 0.42, 2.21, '<Other>', 0, 23, '2011-11-27 07:56:24'),
(52, 'Ruty Hacujo', 17.5, 19.57, 1, 0, 0, 0, 0, 0, 0, 0, 2, -1.81, 1.09, '<Other>', 0, 5, '2007-01-27 11:32:33'),
(53, 'Leti Fupahu', 51.2, 20.57, 1, 0, 0, 0, 0, 0, 0, 0, 8, -0.22, 0.41, '<Other>', 0, 16, '2011-07-22 13:48:40'),
(54, 'Pyti Sipisy', 79.3, 21.49, 1, 1, 0, 0, 1, 0, 0, 0, 2, -0.31, 0.32, '<Other>', 0, 15, '2009-04-05 09:52:48'),
(55, 'Xeko Gahacy', 62.8, 27.62, 1, 1, 0, 0, 0, 0, 0, 0, 2, -0.86, -0.31, '<Other>', 0, 11, '2008-12-01 11:33:33'),
(56, 'Cohy Jahoco', 61.9, 20, 1, 0, 0, 0, 0, 0, 0, 1, 3, 1.03, 1.65, '<Other>', 0, 15, '2008-07-03 13:24:12'),
(57, 'Roho Hinylo', 56.9, 28.6, 0, 0, 0, 0, 0, 0, 0, 0, 0, -3.27, -0.27, '<Other>', 0, 5, '2008-05-11 07:47:31'),
(58, 'Pofo Mitutu', 74.4, 22.48, 1, 0, 0, 0, 0, 0, 0, 0, 2, -0.45, 1.14, '<Other>', 0, 13, '2011-01-30 12:15:27'),
(59, 'Nori Gyhiva', 59.3, 25.39, 1, 0, 0, 0, 1, 0, 0, 1, 9, -1.41, 0.92, '<Other>', 0, 19, '2002-02-01 10:48:37'),
(60, 'Fovo Mijire', 70.6, 25.85, 1, 0, 0, 0, 0, 0, 0, 0, 2, -0.81, 0.52, '<Other>', 0, 12, '2000-10-23 13:16:25'),
(61, 'Vido Mafydy', 77.8, 20, 1, 1, 0, 0, 0, 0, 1, 0, 2, 1.48, 1.36, '<Other>', 0, 17, '2005-07-18 07:05:28'),
(62, 'Tuge Ditide', 82.8, 22.58, 1, 1, 0, 0, 0, 0, 0, 0, 2, -0.47, -0.26, '<Other>', 0, 13, '2009-11-11 10:07:44'),
(63, 'Lypi Hoduty', 80.7, 28.09, 1, 1, 1, 0, 0, 0, 1, 1, 4, -0.34, 3.95, '<Other>', 0, 23, '2013-02-16 15:52:11'),
(64, 'Kuvy Kahuje', 29.8, 19.47, 1, 0, 0, 0, 0, 0, 0, 0, 6, -0.14, 1.72, '<Other>', 0, 13, '2007-10-11 11:03:56'),
(65, 'Lyju Pabyny', 49.8, 26.8, 1, 0, 0, 0, 0, 0, 0, 0, 2, 0.85, 0.41, '<Other>', 0, 11, '2002-10-07 10:48:23'),
(66, 'Kuje Fyluqo', 57, 31.05, 1, 1, 0, 0, 0, 0, 0, 0, 3, -1.01, -0.37, '<Other>', 0, 12, '2013-03-18 09:58:13'),
(67, 'Kali Syleto', 55.6, 21.29, 0, 0, 0, 0, 0, 0, 0, 1, 1, -0.19, 1.96, '<Other>', 0, 11, '2000-09-22 10:37:26'),
(68, 'Newy Gamopi', 77, 31.38, 1, 1, 0, 0, 0, 0, 0, 0, 9, -0.06, 0.46, '<Other>', 0, 22, '2009-08-04 14:11:00'),
(69, 'Cedy Tamywa', 67, 20, 1, 0, 0, 0, 1, 0, 1, 1, 9, -0.83, 4.16, '<Other>', 0, 25, '2004-01-21 07:48:03'),
(70, 'Xuli Vehydi', 28.2, 21.33, 0, 0, 0, 0, 0, 0, 0, 1, 1, -0.99, 0.62, '<Other>', 0, 6, '2010-04-07 06:46:11'),
(71, 'Mice Neqimu', 53.4, 21.33, 1, 0, 0, 0, 0, 0, 0, 0, 6, -0.95, 0.63, '<Other>', 0, 14, '2004-10-13 13:58:19'),
(72, 'Xamu Gojyqo', 75.9, 33.6, 1, 0, 0, 0, 0, 0, 0, 1, 3, -0.79, 0.5, '<Other>', 0, 15, '2006-12-10 09:19:55'),
(73, 'Levi Jenagu', 77.5, 20, 1, 1, 0, 0, 0, 0, 0, 0, 7, -1.18, -0.2, '<Other>', 0, 17, '2002-10-26 08:44:33'),
(74, 'Lagy Sikyhe', 79.7, 28.38, 1, 1, 0, 0, 0, 0, 0, 0, 2, -1.81, 1.14, '<Other>', 0, 14, '2002-03-27 09:32:27'),
(75, 'Faru Sarycy', 81.6, 23.48, 1, 1, 0, 1, 0, 0, 0, 1, 4, -0.75, 0, '<Other>', 0, 17, '2002-10-23 13:04:02'),
(76, 'Gyfy Kyluqu', 16.7, 20, 0, 0, 0, 0, 0, 0, 0, 0, 0, -0.82, 0.41, '<Other>', 0, 3, '2012-03-13 13:08:10'),
(77, 'Diby Jurylo', 70, 38.96, 1, 1, 0, 0, 0, 0, 0, 1, 3, -2.03, -0.68, '<Other>', 0, 14, '2007-12-09 09:21:48'),
(78, 'Xyqy Nuxija', 80, 21.6, 1, 1, 0, 0, 0, 0, 0, 1, 10, 1.82, 6.38, '<Other>', 0, 31, '2003-06-05 06:46:54'),
(79, 'Boqu Jasylo', 39.1, 28.35, 1, 0, 0, 0, 0, 0, 0, 0, 2, -0.67, 0.41, '<Other>', 0, 9, '2012-02-23 11:04:19'),
(80, 'Nyfu Xymeju', 57, 20, 1, 1, 0, 0, 0, 0, 0, 0, 8, 1.43, 1.75, '<Other>', 0, 20, '2010-07-17 12:35:57'),
(81, 'Lule Xajepy', 76.4, 24.98, 0, 1, 0, 0, 0, 0, 0, 1, 1, -1.48, -0.13, '<Other>', 0, 11, '2010-04-14 08:49:52'),
(82, 'Xaca Bucuni', 66.6, 25.25, 1, 1, 0, 1, 0, 0, 0, 0, 3, 1.26, 0.77, '<Other>', 0, 17, '2005-05-20 13:41:37'),
(83, 'Nare Peluqe', 18.8, 19.34, 1, 0, 0, 0, 0, 0, 0, 0, 8, -0.78, 0.26, '<Other>', 0, 12, '2001-04-04 06:39:24'),
(84, 'Ropo Qelame', 47.3, 20.97, 1, 1, 0, 0, 0, 0, 0, 0, 6, -0.72, 0.36, '<Other>', 0, 14, '2010-09-12 10:22:28'),
(85, 'Lali Dymisu', 74.3, 28.72, 1, 0, 0, 0, 0, 0, 0, 0, 8, -0.66, 0, '<Other>', 0, 18, '2004-01-05 09:58:13'),
(86, 'Dela Mixofi', 56.6, 37.58, 1, 1, 0, 0, 0, 0, 0, 0, 2, -1.87, 0.14, '<Other>', 0, 11, '2000-12-12 10:02:15'),
(87, 'Xepi Bykupi', 71.7, 25.18, 1, 1, 0, 1, 0, 0, 0, 0, 1, -2.88, -0.58, '<Other>', 0, 10, '2005-03-12 12:23:48'),
(88, 'Robu Bagosu', 55.7, 20, 1, 1, 0, 0, 0, 0, 0, 0, 2, -0.81, 0.14, '<Other>', 0, 10, '2008-05-25 06:44:44'),
(89, 'Homa Japefe', 1, 15.71, 0, 0, 0, 0, 0, 0, 0, 0, 0, -1.15, 0.52, '<Other>', 0, 1, '2012-12-05 07:42:43'),
(90, 'Leqi Tutuja', 13.4, 17.65, 1, 0, 0, 0, 0, 0, 0, 0, 6, -0.58, 0.63, '<Other>', 0, 10, '2009-02-02 07:49:21'),
(91, 'Myqa Jajisu', 74.9, 29.21, 1, 1, 0, 0, 0, 0, 0, 0, 8, -0.81, 0.14, '<Other>', 0, 19, '2001-11-12 12:30:43'),
(92, 'Wojy Lajery', 79.2, 20, 1, 1, 0, 0, 0, 0, 0, 1, 3, -2.46, -0.43, '<Other>', 0, 13, '2006-01-30 12:53:37'),
(93, 'Fipi Senuhu', 66.3, 23.46, 1, 0, 0, 0, 0, 0, 0, 1, 3, -1.62, 0.34, '<Other>', 0, 12, '2002-02-05 12:32:44'),
(94, 'Tyge Saloma', 57.5, 29.81, 0, 0, 0, 0, 0, 0, 0, 1, 1, -1.34, -0.39, '<Other>', 0, 9, '2004-04-29 07:02:27'),
(95, 'Lopi Saqyla', 58.8, 25.24, 0, 0, 0, 0, 1, 0, 0, 1, 0, -1.15, 0, '<Other>', 0, 9, '2001-03-17 09:20:12'),
(96, 'Weny Mudyky', 77, 22.5, 1, 1, 0, 1, 0, 0, 0, 1, 5, 1.24, 1.81, '<Other>', 0, 22, '2012-09-23 14:53:54'),
(97, 'Wyca Ryrupa', 63.1, 25.47, 1, 0, 0, 0, 0, 0, 1, 1, 3, -0.28, 0.59, '<Other>', 0, 15, '2011-07-13 13:48:14'),
(98, 'Celo Gelypo', 76.8, 24.69, 1, 1, 0, 0, 0, 0, 0, 1, 3, -1.09, 0.16, '<Other>', 0, 15, '2013-01-14 11:33:42'),
(99, 'Jaku Padito', 66.8, 37.95, 1, 1, 0, 1, 0, 0, 0, 0, 7, -1.09, 0.36, '<Other>', 0, 19, '2010-03-05 08:27:04');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `patient_table`
--
ALTER TABLE `patient_table`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `patient_table`
--
ALTER TABLE `patient_table`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=100;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
