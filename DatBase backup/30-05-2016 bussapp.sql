-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Värd: 127.0.0.1
-- Tid vid skapande: 30 maj 2016 kl 20:42
-- Serverversion: 10.1.13-MariaDB
-- PHP-version: 5.6.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Databas: `bussapp`
--

-- --------------------------------------------------------

--
-- Tabellstruktur `bustrip`
--

CREATE TABLE `bustrip` (
  `trip-ID` int(11) NOT NULL,
  `totalspots` int(11) NOT NULL,
  `availablespots` int(11) NOT NULL,
  `departuretime` datetime NOT NULL,
  `arrivaltime` datetime NOT NULL,
  `destination` int(11) NOT NULL,
  `origin` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumpning av Data i tabell `bustrip`
--

INSERT INTO `bustrip` (`trip-ID`, `totalspots`, `availablespots`, `departuretime`, `arrivaltime`, `destination`, `origin`) VALUES
(1, 50, 50, '2016-07-01 08:25:00', '2016-07-01 09:21:05', 1, 2),
(2, 20, 20, '2016-06-01 10:00:00', '2016-06-01 11:10:00', 3, 2),
(3, 20, 20, '2016-06-01 12:00:00', '2016-06-01 13:30:00', 1, 3),
(4, 20, 20, '2016-06-15 09:00:00', '2016-06-15 09:48:00', 2, 1),
(5, 50, 50, '2016-06-09 15:00:00', '2016-06-09 16:13:00', 2, 3),
(6, 20, 20, '2016-06-13 12:00:00', '2016-06-13 13:30:00', 3, 1);

-- --------------------------------------------------------

--
-- Tabellstruktur `city`
--

CREATE TABLE `city` (
  `cityID` int(11) NOT NULL,
  `name` varchar(50) NOT NULL,
  `language` varchar(50) NOT NULL,
  `currency` varchar(50) NOT NULL,
  `country` varchar(50) NOT NULL,
  `timezone` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumpning av Data i tabell `city`
--

INSERT INTO `city` (`cityID`, `name`, `language`, `currency`, `country`, `timezone`) VALUES
(1, 'Skivarp', 'Svenska', 'SEK', 'Sverige', 'GMT +1'),
(2, 'Malmö', 'Svenska', 'SEK', 'Sverige', 'GMT +1'),
(3, 'Domsten', 'Svenska', 'SEK', 'Sverige', 'GMT +1');

-- --------------------------------------------------------

--
-- Tabellstruktur `customer`
--

CREATE TABLE `customer` (
  `firstname` varchar(50) NOT NULL,
  `lastname` varchar(50) NOT NULL,
  `personID` varchar(20) NOT NULL,
  `adress` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL,
  `customerID` int(11) NOT NULL,
  `phonenumber` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumpning av Data i tabell `customer`
--

INSERT INTO `customer` (`firstname`, `lastname`, `personID`, `adress`, `email`, `customerID`, `phonenumber`) VALUES
('oskar', 'nilsson', '900105-1359', 'bygatan 21', 'nilsson.o.90@gmail.com', 4, '0707-703676'),
('thisguy', 'dudeson', 'yes', 'waefra', 'lololol', 5, '05472472'),
('Joel', 'Nilsson', '9210283793', 'Amiralsgatan 84B', 'joel@joel.com', 6, '0761178885');

-- --------------------------------------------------------

--
-- Tabellstruktur `ticket`
--

CREATE TABLE `ticket` (
  `ticket-ID` int(11) NOT NULL,
  `type` varchar(50) NOT NULL,
  `price` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Tabellstruktur `ticketowner`
--

CREATE TABLE `ticketowner` (
  `ticket-ID` int(11) NOT NULL,
  `customer-ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Tabellstruktur `validity`
--

CREATE TABLE `validity` (
  `ticket-ID` int(11) NOT NULL,
  `trip-ID` int(11) NOT NULL,
  `seat-Nr` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Index för dumpade tabeller
--

--
-- Index för tabell `bustrip`
--
ALTER TABLE `bustrip`
  ADD PRIMARY KEY (`trip-ID`),
  ADD KEY `origin` (`origin`),
  ADD KEY `destination` (`destination`),
  ADD KEY `trip-ID` (`trip-ID`);

--
-- Index för tabell `city`
--
ALTER TABLE `city`
  ADD PRIMARY KEY (`cityID`),
  ADD UNIQUE KEY `city-ID` (`cityID`),
  ADD KEY `city-ID_2` (`cityID`);

--
-- Index för tabell `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`customerID`);

--
-- Index för tabell `ticket`
--
ALTER TABLE `ticket`
  ADD PRIMARY KEY (`ticket-ID`),
  ADD KEY `ticket-ID` (`ticket-ID`);

--
-- Index för tabell `ticketowner`
--
ALTER TABLE `ticketowner`
  ADD PRIMARY KEY (`ticket-ID`,`customer-ID`),
  ADD KEY `customer-ID` (`customer-ID`),
  ADD KEY `ticket-ID` (`ticket-ID`),
  ADD KEY `customer-ID_2` (`customer-ID`),
  ADD KEY `ticket-ID_2` (`ticket-ID`);

--
-- Index för tabell `validity`
--
ALTER TABLE `validity`
  ADD PRIMARY KEY (`ticket-ID`,`trip-ID`),
  ADD KEY `ticket-ID` (`ticket-ID`),
  ADD KEY `trip-ID` (`trip-ID`);

--
-- AUTO_INCREMENT för dumpade tabeller
--

--
-- AUTO_INCREMENT för tabell `bustrip`
--
ALTER TABLE `bustrip`
  MODIFY `trip-ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT för tabell `city`
--
ALTER TABLE `city`
  MODIFY `cityID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT för tabell `customer`
--
ALTER TABLE `customer`
  MODIFY `customerID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT för tabell `ticket`
--
ALTER TABLE `ticket`
  MODIFY `ticket-ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- Restriktioner för dumpade tabeller
--

--
-- Restriktioner för tabell `bustrip`
--
ALTER TABLE `bustrip`
  ADD CONSTRAINT `destinationFK` FOREIGN KEY (`destination`) REFERENCES `city` (`cityID`),
  ADD CONSTRAINT `originFK` FOREIGN KEY (`origin`) REFERENCES `city` (`cityID`);

--
-- Restriktioner för tabell `ticketowner`
--
ALTER TABLE `ticketowner`
  ADD CONSTRAINT `customerFK` FOREIGN KEY (`customer-ID`) REFERENCES `customer` (`customerID`),
  ADD CONSTRAINT `ticketFK` FOREIGN KEY (`ticket-ID`) REFERENCES `ticket` (`ticket-ID`);

--
-- Restriktioner för tabell `validity`
--
ALTER TABLE `validity`
  ADD CONSTRAINT `validticketFK` FOREIGN KEY (`ticket-ID`) REFERENCES `ticket` (`ticket-ID`),
  ADD CONSTRAINT `validtripFK` FOREIGN KEY (`trip-ID`) REFERENCES `bustrip` (`trip-ID`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
