-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Czas generowania: 07 Sty 2022, 11:58
-- Wersja serwera: 10.4.22-MariaDB
-- Wersja PHP: 8.1.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Baza danych: `patient`
--

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `patient_table`
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
-- Zrzut danych tabeli `patient_table`
--

INSERT INTO `patient_table` (`ID`, `Name`, `Age`, `BMI`, `Cancer`, `CVD`, `Dementia`, `Diabetes`, `Digestive`, `Osteoart`, `Psych`, `Pulmonary`, `Charlson`, `Mortality_rsi`, `Complication_rsi`, `Surgery_type`, `JUP_priority_predicted`, `JUP_priority_ideal`, `CreateAt`) VALUES
(12, 'Franek Bąk', 132, 34, 0, 0, 1, 1, 0, 0, 1, 1, 5, 2, 3, 'Flu', 15, 0, '2022-01-03 15:33:31'),
(13, 'errerer', 34, 45, 1, 1, 1, 0, 0, 0, 0, 0, 3, 1, 2, 'katar', 15, 0, '2022-01-07 09:45:15'),
(14, 'Mikolaj', 10, 20, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 'grypa', 3, 0, '2022-01-07 09:45:51'),
(15, 'Edward', 100, 50, 1, 1, 1, 1, 1, 1, 0, 0, 4, 1, 1, 'smierc', 19, 0, '2022-01-07 09:46:31'),
(16, 'jedenzrekordow', 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 3, 0, 0, 'niewiem', 1, 0, '2022-01-07 09:48:42'),
(17, 'jeszczeraz', 0, 25.77, 1, 0, 0, 0, 0, 0, 0, 1, 3, -1.34, 0.39, 'rrrr', 3, 0, '2022-01-07 09:49:28'),
(18, 'rrr', 0, 25.77, 1, 0, 0, 0, 0, 0, 0, 0, 0, -1.34, 0.39, 'fffffffffff', 2, 0, '2022-01-07 09:50:05'),
(19, 'eeee', 46, 25.77, 1, 0, 0, 0, 0, 0, 0, 1, 3, -1.34, 0.39, 'tttt', 12, 0, '2022-01-07 09:53:25'),
(20, 'Waldemar', 45.8, 28.77, 1, 0, 0, 0, 0, 0, 0, 1, 3, -1.34, 0.39, 'Kolano', 12, 13, '2022-01-07 09:57:57'),
(21, 'rere', 34, 34, 1, 1, 1, 1, 0, 0, 0, 0, 5, 2, 3, 'rrrrr', 21, 0, '2022-01-07 10:54:34');

--
-- Indeksy dla zrzutów tabel
--

--
-- Indeksy dla tabeli `patient_table`
--
ALTER TABLE `patient_table`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT dla zrzuconych tabel
--

--
-- AUTO_INCREMENT dla tabeli `patient_table`
--
ALTER TABLE `patient_table`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
