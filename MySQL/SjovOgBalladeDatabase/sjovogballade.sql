-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Vært: 127.0.0.1
-- Genereringstid: 28. 11 2019 kl. 12:09:24
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
-- Database: `sjovogballade`
--

DELIMITER $$
--
-- Procedurer
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `delete_order` (IN `ID` INT(11))  BEGIN

DELETE FROM orders WHERE orders.OrderID=ID;
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Struktur-dump for tabellen `addresses`
--

CREATE TABLE `addresses` (
  `addr_id` int(11) NOT NULL,
  `user_id` int(11) DEFAULT NULL,
  `adresses` varchar(255) DEFAULT NULL,
  `city` varchar(255) DEFAULT NULL,
  `zipcode` int(11) DEFAULT NULL,
  `country` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Data dump for tabellen `addresses`
--

INSERT INTO `addresses` (`addr_id`, `user_id`, `adresses`, `city`, `zipcode`, `country`) VALUES
(1, 1, 'Poulvej 1', 'Ny Poulrup', 1337, 'Pouland'),
(2, 2, 'Poulvej 2', 'Ny Poulrup', 1337, 'Pouland'),
(3, 4, 'Poulvej 4', 'Ny Poulrup', 1337, 'Pouland'),
(4, 5, 'Poulvej 5', 'Ny Poulrup', 1337, 'Pouland'),
(5, 6, 'Poulvej 6', 'Ny Poulrup', 1337, 'Pouland'),
(6, 3, 'Poulvej 7', 'Ny Poulrup', 1337, 'Pouland'),
(7, 7, 'Poulvej 9', 'Ny Poulrup', 1337, 'Pouland'),
(8, 8, 'Poulvej 3', 'Ny Poulrup', 1337, 'Pouland'),
(9, 9, 'Poulvej 8', 'Ny Poulrup', 1337, 'Pouland'),
(10, 9, 'Poulvej 10', 'Ny Poulrup', 1337, 'Pouland');

-- --------------------------------------------------------

--
-- Stand-in-struktur for visning `leftorders_user`
-- (Se nedenfor for det aktuelle view)
--
CREATE TABLE `leftorders_user` (
`OrderID` int(11)
,`PersonID` int(11)
,`Description` varchar(500)
,`prod_id` int(11)
,`addr_id` int(11)
,`UserID` int(11)
,`username` varchar(255)
,`firstName` varchar(255)
,`lastName` varchar(255)
,`Email` varchar(255)
);

-- --------------------------------------------------------

--
-- Stand-in-struktur for visning `leftusers_orders`
-- (Se nedenfor for det aktuelle view)
--
CREATE TABLE `leftusers_orders` (
`UserID` int(11)
,`username` varchar(255)
,`firstName` varchar(255)
,`lastName` varchar(255)
,`Email` varchar(255)
,`OrderID` int(11)
,`PersonID` int(11)
,`Description` varchar(500)
,`prod_id` int(11)
,`addr_id` int(11)
);

-- --------------------------------------------------------

--
-- Stand-in-struktur for visning `name_address`
-- (Se nedenfor for det aktuelle view)
--
CREATE TABLE `name_address` (
`username` varchar(255)
,`adresses` varchar(255)
);

-- --------------------------------------------------------

--
-- Struktur-dump for tabellen `orders`
--

CREATE TABLE `orders` (
  `OrderID` int(11) NOT NULL,
  `PersonID` int(11) DEFAULT NULL,
  `Description` varchar(500) NOT NULL,
  `prod_id` int(11) DEFAULT NULL,
  `addr_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Data dump for tabellen `orders`
--

INSERT INTO `orders` (`OrderID`, `PersonID`, `Description`, `prod_id`, `addr_id`) VALUES
(3, 4, 'hej', 5, 4),
(4, 9, 'Jeg mangler sådan en her!', 1, 6),
(5, 3, 'Jeg kan godt li ræs!', 2, 8),
(6, 5, 'uden champignon!', 3, 4);

-- --------------------------------------------------------

--
-- Stand-in-struktur for visning `productid_name`
-- (Se nedenfor for det aktuelle view)
--
CREATE TABLE `productid_name` (
`prod_name` varchar(255)
,`prod_id` int(11)
);

-- --------------------------------------------------------

--
-- Struktur-dump for tabellen `products`
--

CREATE TABLE `products` (
  `prod_id` int(11) NOT NULL,
  `prod_name` varchar(255) DEFAULT NULL,
  `prod_desc` varchar(500) DEFAULT NULL,
  `prod_stock` int(11) DEFAULT NULL,
  `prod_price` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Data dump for tabellen `products`
--

INSERT INTO `products` (`prod_id`, `prod_name`, `prod_desc`, `prod_stock`, `prod_price`) VALUES
(1, 'tennisbold', 'ikke tilsæt til kugler', 13, 19.99),
(2, 'solcreme', '200 IQ køb', 2147483647, 0.99),
(3, 'paraply', 'Du skulle nok ha overvejet at købe sådan en noget tidligere', 0, 199.99),
(4, 'solcreme', '200 IQ køb', 2147483647, 0.99),
(5, 'paraply', 'Du skulle nok ha overvejet at købe sådan en noget tidligere', 0, 199.99),
(6, 'Hindbærsnitte', 'Bedste kage nogensinde', 4, 10);

-- --------------------------------------------------------

--
-- Struktur-dump for tabellen `users`
--

CREATE TABLE `users` (
  `UserID` int(11) NOT NULL,
  `username` varchar(255) DEFAULT NULL,
  `firstName` varchar(255) DEFAULT NULL,
  `lastName` varchar(255) DEFAULT NULL,
  `Email` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Data dump for tabellen `users`
--

INSERT INTO `users` (`UserID`, `username`, `firstName`, `lastName`, `Email`) VALUES
(1, 'Gilga', 'Gilgazor', 'TheDestroyer', 'email1@email.gg'),
(2, 'XxSmiterOfGodsxX69', 'Oliver', 'Olesen', 'email2@email.gg'),
(3, 'PenIsland', 'George', 'Georgeson', 'email3@email.gg'),
(4, 'SpectralOrangutang', 'Nice', 'TryFBI', 'huehue@lortemail.dk'),
(5, 'asdfuser', 'name', 'name2', 'email4@email.gg'),
(6, 'CakeLover13', 'Andreas', 'German', 'andreasTheG@google.com'),
(7, 'ReneGade', 'Rene', 'Gade', 'renegader@viborg.dk'),
(8, 'ThaiThanh', 'Thai', 'Thanh', 'bigdig@energi.dk'),
(9, 'seksvageen', 'lolman', 'kek', 'pepekekomega@lulz.mong'),
(10, 'timmy2014', 'timmy', 'johnson', 'email1337@email.gg');

-- --------------------------------------------------------

--
-- Stand-in-struktur for visning `user_orders`
-- (Se nedenfor for det aktuelle view)
--
CREATE TABLE `user_orders` (
`username` varchar(255)
,`prod_id` int(11)
);

-- --------------------------------------------------------

--
-- Struktur for visning `leftorders_user`
--
DROP TABLE IF EXISTS `leftorders_user`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `leftorders_user`  AS  select `orders`.`OrderID` AS `OrderID`,`orders`.`PersonID` AS `PersonID`,`orders`.`Description` AS `Description`,`orders`.`prod_id` AS `prod_id`,`orders`.`addr_id` AS `addr_id`,`users`.`UserID` AS `UserID`,`users`.`username` AS `username`,`users`.`firstName` AS `firstName`,`users`.`lastName` AS `lastName`,`users`.`Email` AS `Email` from (`orders` left join `users` on(`orders`.`PersonID` = `users`.`UserID`)) ;

-- --------------------------------------------------------

--
-- Struktur for visning `leftusers_orders`
--
DROP TABLE IF EXISTS `leftusers_orders`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `leftusers_orders`  AS  select `users`.`UserID` AS `UserID`,`users`.`username` AS `username`,`users`.`firstName` AS `firstName`,`users`.`lastName` AS `lastName`,`users`.`Email` AS `Email`,`orders`.`OrderID` AS `OrderID`,`orders`.`PersonID` AS `PersonID`,`orders`.`Description` AS `Description`,`orders`.`prod_id` AS `prod_id`,`orders`.`addr_id` AS `addr_id` from (`users` left join `orders` on(`users`.`UserID` = `orders`.`PersonID`)) ;

-- --------------------------------------------------------

--
-- Struktur for visning `name_address`
--
DROP TABLE IF EXISTS `name_address`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `name_address`  AS  select `users`.`username` AS `username`,`addresses`.`adresses` AS `adresses` from (`users` join `addresses` on(`users`.`UserID` = `addresses`.`user_id`)) ;

-- --------------------------------------------------------

--
-- Struktur for visning `productid_name`
--
DROP TABLE IF EXISTS `productid_name`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `productid_name`  AS  select `products`.`prod_name` AS `prod_name`,`orders`.`prod_id` AS `prod_id` from (`products` join `orders` on(`products`.`prod_id` = `orders`.`prod_id`)) ;

-- --------------------------------------------------------

--
-- Struktur for visning `user_orders`
--
DROP TABLE IF EXISTS `user_orders`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `user_orders`  AS  select `users`.`username` AS `username`,`orders`.`prod_id` AS `prod_id` from (`users` join `orders` on(`users`.`UserID` = `orders`.`PersonID`)) ;

--
-- Begrænsninger for dumpede tabeller
--

--
-- Indeks for tabel `addresses`
--
ALTER TABLE `addresses`
  ADD PRIMARY KEY (`addr_id`),
  ADD KEY `user_id` (`user_id`);

--
-- Indeks for tabel `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`OrderID`),
  ADD KEY `PersonID` (`PersonID`),
  ADD KEY `prod_id` (`prod_id`),
  ADD KEY `addr_id` (`addr_id`);

--
-- Indeks for tabel `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`prod_id`);

--
-- Indeks for tabel `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`UserID`);

--
-- Brug ikke AUTO_INCREMENT for slettede tabeller
--

--
-- Tilføj AUTO_INCREMENT i tabel `addresses`
--
ALTER TABLE `addresses`
  MODIFY `addr_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- Tilføj AUTO_INCREMENT i tabel `orders`
--
ALTER TABLE `orders`
  MODIFY `OrderID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- Tilføj AUTO_INCREMENT i tabel `products`
--
ALTER TABLE `products`
  MODIFY `prod_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- Tilføj AUTO_INCREMENT i tabel `users`
--
ALTER TABLE `users`
  MODIFY `UserID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- Begrænsninger for dumpede tabeller
--

--
-- Begrænsninger for tabel `addresses`
--
ALTER TABLE `addresses`
  ADD CONSTRAINT `addresses_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `users` (`UserID`);

--
-- Begrænsninger for tabel `orders`
--
ALTER TABLE `orders`
  ADD CONSTRAINT `orders_ibfk_1` FOREIGN KEY (`PersonID`) REFERENCES `users` (`UserID`),
  ADD CONSTRAINT `orders_ibfk_2` FOREIGN KEY (`prod_id`) REFERENCES `products` (`prod_id`),
  ADD CONSTRAINT `orders_ibfk_3` FOREIGN KEY (`addr_id`) REFERENCES `addresses` (`addr_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
