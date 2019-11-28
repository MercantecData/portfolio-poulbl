-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Vært: 127.0.0.1
-- Genereringstid: 28. 11 2019 kl. 12:08:54
-- Serverversion: 10.4.8-MariaDB
-- PHP-version: 7.3.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `poulsemporium`
--

-- --------------------------------------------------------

--
-- Struktur-dump for tabellen `department`
--

CREATE TABLE `department` (
  `dep_id` int(11) NOT NULL,
  `name` varchar(255) DEFAULT NULL,
  `num_employees` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Data dump for tabellen `department`
--

INSERT INTO `department` (`dep_id`, `name`, `num_employees`) VALUES
(1, 'Research and Development', 42),
(2, 'Human Resources', 73),
(3, 'Management', 7);

-- --------------------------------------------------------

--
-- Stand-in-struktur for visning `dep_employees`
-- (Se nedenfor for det aktuelle view)
--
CREATE TABLE `dep_employees` (
`first_name` varchar(255)
,`name` varchar(255)
);

-- --------------------------------------------------------

--
-- Stand-in-struktur for visning `dep_mans`
-- (Se nedenfor for det aktuelle view)
--
CREATE TABLE `dep_mans` (
`first_name` varchar(255)
,`name` varchar(255)
);

-- --------------------------------------------------------

--
-- Struktur-dump for tabellen `employee`
--

CREATE TABLE `employee` (
  `emp_id` int(11) NOT NULL,
  `first_name` varchar(255) DEFAULT NULL,
  `middle_name` varchar(255) DEFAULT NULL,
  `last_name` varchar(255) DEFAULT NULL,
  `email` varchar(255) DEFAULT NULL,
  `departmentid` int(11) DEFAULT NULL,
  `title` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Data dump for tabellen `employee`
--

INSERT INTO `employee` (`emp_id`, `first_name`, `middle_name`, `last_name`, `email`, `departmentid`, `title`) VALUES
(1, 'Jesper', '', 'Hansen', 'jesperhansen@poulmail.com', 1, 5),
(2, 'Poul', 'Bach', 'Lauritsen', 'poulbachlauritsen@poulmail.com', 3, 1),
(3, 'William', 'Den', 'Dumme', 'william@poulmail.com', 1, 5),
(4, 'Karl', 'Johannes', 'Thismand', 'karlthismand@poulmail.com', 1, 5),
(5, 'William', 'Den', 'Dumme', 'william@poulmail.com', 1, 5),
(6, 'Karl', 'Johannes', 'Thismand', 'karlthismand@poulmail.com', 1, 5),
(7, 'Johannes', 'Johan', 'Johansen', 'jojojohahaha@poulmail.com', 1, 4),
(8, 'Test', 'Test', 'Test', 'test@poulmail.com', 1, 3),
(9, 'Kasper', 'Jesper', 'Jonathan', 'xD@poulmail.com', 1, 2),
(10, 'TOmmy', 'Fejl', 'Syntax', 'tommy@poulmail.com', 1, 5),
(11, 'Mario', '', 'Super', 'supermario@poulmail.com', 2, 2),
(12, 'Luigi', '', 'KindaSuper', 'luigi@poulmail.com', 2, 3),
(13, 'Tobias', '', 'Bruh', 'Tobias@poulmail.com', 2, 4);

-- --------------------------------------------------------

--
-- Stand-in-struktur for visning `employee_salaries`
-- (Se nedenfor for det aktuelle view)
--
CREATE TABLE `employee_salaries` (
`first_name` varchar(255)
,`salary` double
);

-- --------------------------------------------------------

--
-- Stand-in-struktur for visning `emp_sal`
-- (Se nedenfor for det aktuelle view)
--
CREATE TABLE `emp_sal` (
`emp_id` int(11)
,`salary` double
);

-- --------------------------------------------------------

--
-- Struktur-dump for tabellen `salaries`
--

CREATE TABLE `salaries` (
  `sal_id` int(11) NOT NULL,
  `title` int(11) DEFAULT NULL,
  `salary` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Data dump for tabellen `salaries`
--

INSERT INTO `salaries` (`sal_id`, `title`, `salary`) VALUES
(1, 1, 1000000),
(2, 2, 100000),
(3, 3, 10000),
(4, 4, 1000),
(5, 5, 0);

-- --------------------------------------------------------

--
-- Struktur-dump for tabellen `titles`
--

CREATE TABLE `titles` (
  `title_id` int(11) NOT NULL,
  `titles` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Data dump for tabellen `titles`
--

INSERT INTO `titles` (`title_id`, `titles`) VALUES
(1, 'BIGBOSS'),
(2, 'Manager'),
(3, 'Veteran'),
(4, 'Praktikant'),
(5, 'Grunt');

-- --------------------------------------------------------

--
-- Struktur for visning `dep_employees`
--
DROP TABLE IF EXISTS `dep_employees`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `dep_employees`  AS  select `employee`.`first_name` AS `first_name`,`department`.`name` AS `name` from (`employee` join `department` on(`employee`.`departmentid` = `department`.`dep_id`)) where `employee`.`title` <> 2 ;

-- --------------------------------------------------------

--
-- Struktur for visning `dep_mans`
--
DROP TABLE IF EXISTS `dep_mans`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `dep_mans`  AS  select `employee`.`first_name` AS `first_name`,`department`.`name` AS `name` from (`employee` join `department` on(`employee`.`departmentid` = `department`.`dep_id`)) where `employee`.`title` = 2 ;

-- --------------------------------------------------------

--
-- Struktur for visning `employee_salaries`
--
DROP TABLE IF EXISTS `employee_salaries`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `employee_salaries`  AS  select `employee`.`first_name` AS `first_name`,`salaries`.`salary` AS `salary` from (`employee` join `salaries` on(`employee`.`title` = `salaries`.`title`)) ;

-- --------------------------------------------------------

--
-- Struktur for visning `emp_sal`
--
DROP TABLE IF EXISTS `emp_sal`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `emp_sal`  AS  select `employee`.`emp_id` AS `emp_id`,`salaries`.`salary` AS `salary` from (`employee` join `salaries` on(`employee`.`title` = `salaries`.`title`)) ;

--
-- Begrænsninger for dumpede tabeller
--

--
-- Indeks for tabel `department`
--
ALTER TABLE `department`
  ADD PRIMARY KEY (`dep_id`);

--
-- Indeks for tabel `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`emp_id`),
  ADD KEY `departmentid` (`departmentid`),
  ADD KEY `title` (`title`);

--
-- Indeks for tabel `salaries`
--
ALTER TABLE `salaries`
  ADD PRIMARY KEY (`sal_id`),
  ADD KEY `title` (`title`);

--
-- Indeks for tabel `titles`
--
ALTER TABLE `titles`
  ADD PRIMARY KEY (`title_id`);

--
-- Brug ikke AUTO_INCREMENT for slettede tabeller
--

--
-- Tilføj AUTO_INCREMENT i tabel `department`
--
ALTER TABLE `department`
  MODIFY `dep_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Tilføj AUTO_INCREMENT i tabel `employee`
--
ALTER TABLE `employee`
  MODIFY `emp_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- Tilføj AUTO_INCREMENT i tabel `salaries`
--
ALTER TABLE `salaries`
  MODIFY `sal_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Tilføj AUTO_INCREMENT i tabel `titles`
--
ALTER TABLE `titles`
  MODIFY `title_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Begrænsninger for dumpede tabeller
--

--
-- Begrænsninger for tabel `employee`
--
ALTER TABLE `employee`
  ADD CONSTRAINT `employee_ibfk_1` FOREIGN KEY (`departmentid`) REFERENCES `department` (`dep_id`),
  ADD CONSTRAINT `employee_ibfk_2` FOREIGN KEY (`title`) REFERENCES `titles` (`title_id`);

--
-- Begrænsninger for tabel `salaries`
--
ALTER TABLE `salaries`
  ADD CONSTRAINT `salaries_ibfk_1` FOREIGN KEY (`title`) REFERENCES `employee` (`title`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
