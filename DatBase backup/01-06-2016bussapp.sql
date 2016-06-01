-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Värd: 127.0.0.1
-- Tid vid skapande: 01 jun 2016 kl 09:08
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
  `tripID` int(11) NOT NULL,
  `totalspots` int(11) NOT NULL,
  `availableseats` int(11) NOT NULL,
  `departuretime` datetime NOT NULL,
  `arrivaltime` datetime NOT NULL,
  `destination` int(11) NOT NULL,
  `origin` int(11) NOT NULL,
  `price` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumpning av Data i tabell `bustrip`
--

INSERT INTO `bustrip` (`tripID`, `totalspots`, `availableseats`, `departuretime`, `arrivaltime`, `destination`, `origin`, `price`) VALUES
(115, 25, 25, '2016-06-01 08:00:00', '2016-06-01 08:50:00', 1, 2, 70),
(116, 25, 25, '2016-06-08 08:00:00', '2016-06-08 08:50:00', 1, 2, 70),
(117, 25, 25, '2016-06-15 08:00:00', '2016-06-15 08:50:00', 1, 2, 70),
(118, 25, 25, '2016-06-22 08:00:00', '2016-06-22 08:50:00', 1, 2, 70),
(119, 25, 25, '2016-06-29 08:00:00', '2016-06-29 08:50:00', 1, 2, 70),
(120, 25, 25, '2016-07-06 08:00:00', '2016-07-06 08:50:00', 1, 2, 70),
(121, 25, 25, '2016-07-13 08:00:00', '2016-07-13 08:50:00', 1, 2, 70),
(122, 25, 25, '2016-07-20 08:00:00', '2016-07-20 08:50:00', 1, 2, 70),
(123, 25, 25, '2016-07-27 08:00:00', '2016-07-27 08:50:00', 1, 2, 70),
(124, 25, 25, '2016-08-03 08:00:00', '2016-08-03 08:50:00', 1, 2, 70),
(125, 25, 25, '2016-08-10 08:00:00', '2016-08-10 08:50:00', 1, 2, 70),
(126, 25, 25, '2016-08-17 08:00:00', '2016-08-17 08:50:00', 1, 2, 70),
(127, 25, 25, '2016-08-24 08:00:00', '2016-08-24 08:50:00', 1, 2, 70),
(128, 25, 25, '2016-08-31 08:00:00', '2016-08-31 08:50:00', 1, 2, 70),
(129, 25, 25, '2016-09-07 08:00:00', '2016-09-07 08:50:00', 1, 2, 70),
(130, 25, 25, '2016-09-14 08:00:00', '2016-09-14 08:50:00', 1, 2, 70),
(131, 25, 25, '2016-09-21 08:00:00', '2016-09-21 08:50:00', 1, 2, 70),
(132, 25, 25, '2016-09-28 08:00:00', '2016-09-28 08:50:00', 1, 2, 70),
(133, 25, 25, '2016-10-05 08:00:00', '2016-10-05 08:50:00', 1, 2, 70),
(134, 25, 25, '2016-10-12 08:00:00', '2016-10-12 08:50:00', 1, 2, 70),
(135, 25, 25, '2016-10-19 08:00:00', '2016-10-19 08:50:00', 1, 2, 70),
(136, 25, 25, '2016-10-26 08:00:00', '2016-10-26 08:50:00', 1, 2, 70),
(137, 25, 25, '2016-11-02 08:00:00', '2016-11-02 08:50:00', 1, 2, 70),
(138, 25, 25, '2016-11-09 08:00:00', '2016-11-09 08:50:00', 1, 2, 70),
(139, 25, 25, '2016-11-16 08:00:00', '2016-11-16 08:50:00', 1, 2, 70),
(140, 25, 25, '2016-11-23 08:00:00', '2016-11-23 08:50:00', 1, 2, 70),
(141, 25, 25, '2016-11-30 08:00:00', '2016-11-30 08:50:00', 1, 2, 70),
(142, 25, 25, '2016-12-07 08:00:00', '2016-12-07 08:50:00', 1, 2, 70),
(143, 25, 25, '2016-12-14 08:00:00', '2016-12-14 08:50:00', 1, 2, 70),
(144, 25, 25, '2016-12-21 08:00:00', '2016-12-21 08:50:00', 1, 2, 70),
(145, 25, 25, '2016-12-28 08:00:00', '2016-12-28 08:50:00', 1, 2, 70),
(146, 25, 25, '2017-01-04 08:00:00', '2017-01-04 08:50:00', 1, 2, 70),
(147, 25, 25, '2017-01-11 08:00:00', '2017-01-11 08:50:00', 1, 2, 70),
(148, 25, 25, '2017-01-18 08:00:00', '2017-01-18 08:50:00', 1, 2, 70),
(149, 25, 25, '2017-01-25 08:00:00', '2017-01-25 08:50:00', 1, 2, 70),
(150, 25, 25, '2017-02-01 08:00:00', '2017-02-01 08:50:00', 1, 2, 70),
(151, 25, 25, '2017-02-08 08:00:00', '2017-02-08 08:50:00', 1, 2, 70),
(152, 25, 25, '2017-02-15 08:00:00', '2017-02-15 08:50:00', 1, 2, 70),
(153, 25, 25, '2017-02-22 08:00:00', '2017-02-22 08:50:00', 1, 2, 70),
(154, 25, 25, '2017-03-01 08:00:00', '2017-03-01 08:50:00', 1, 2, 70),
(155, 25, 25, '2017-03-08 08:00:00', '2017-03-08 08:50:00', 1, 2, 70),
(156, 25, 25, '2017-03-15 08:00:00', '2017-03-15 08:50:00', 1, 2, 70),
(157, 25, 25, '2017-03-22 08:00:00', '2017-03-22 08:50:00', 1, 2, 70),
(158, 25, 25, '2017-03-29 08:00:00', '2017-03-29 08:50:00', 1, 2, 70),
(159, 25, 25, '2017-04-05 08:00:00', '2017-04-05 08:50:00', 1, 2, 70),
(160, 25, 25, '2017-04-12 08:00:00', '2017-04-12 08:50:00', 1, 2, 70),
(161, 25, 25, '2017-04-19 08:00:00', '2017-04-19 08:50:00', 1, 2, 70),
(162, 25, 25, '2017-04-26 08:00:00', '2017-04-26 08:50:00', 1, 2, 70),
(163, 25, 25, '2017-05-03 08:00:00', '2017-05-03 08:50:00', 1, 2, 70),
(164, 25, 25, '2017-05-10 08:00:00', '2017-05-10 08:50:00', 1, 2, 70),
(165, 25, 25, '2017-05-17 08:00:00', '2017-05-17 08:50:00', 1, 2, 70),
(166, 25, 25, '2017-05-24 08:00:00', '2017-05-24 08:50:00', 1, 2, 70),
(167, 25, 25, '2016-06-01 17:30:00', '2016-06-01 18:20:00', 2, 1, 70),
(168, 25, 25, '2016-06-08 17:30:00', '2016-06-08 18:20:00', 2, 1, 70),
(169, 25, 25, '2016-06-15 17:30:00', '2016-06-15 18:20:00', 2, 1, 70),
(170, 25, 25, '2016-06-22 17:30:00', '2016-06-22 18:20:00', 2, 1, 70),
(171, 25, 25, '2016-06-29 17:30:00', '2016-06-29 18:20:00', 2, 1, 70),
(172, 25, 25, '2016-07-06 17:30:00', '2016-07-06 18:20:00', 2, 1, 70),
(173, 25, 25, '2016-07-13 17:30:00', '2016-07-13 18:20:00', 2, 1, 70),
(174, 25, 25, '2016-07-20 17:30:00', '2016-07-20 18:20:00', 2, 1, 70),
(175, 25, 25, '2016-07-27 17:30:00', '2016-07-27 18:20:00', 2, 1, 70),
(176, 25, 25, '2016-08-03 17:30:00', '2016-08-03 18:20:00', 2, 1, 70),
(177, 25, 25, '2016-08-10 17:30:00', '2016-08-10 18:20:00', 2, 1, 70),
(178, 25, 25, '2016-08-17 17:30:00', '2016-08-17 18:20:00', 2, 1, 70),
(179, 25, 25, '2016-08-24 17:30:00', '2016-08-24 18:20:00', 2, 1, 70),
(180, 25, 25, '2016-08-31 17:30:00', '2016-08-31 18:20:00', 2, 1, 70),
(181, 25, 25, '2016-09-07 17:30:00', '2016-09-07 18:20:00', 2, 1, 70),
(182, 25, 25, '2016-09-14 17:30:00', '2016-09-14 18:20:00', 2, 1, 70),
(183, 25, 25, '2016-09-21 17:30:00', '2016-09-21 18:20:00', 2, 1, 70),
(184, 25, 25, '2016-09-28 17:30:00', '2016-09-28 18:20:00', 2, 1, 70),
(185, 25, 25, '2016-10-05 17:30:00', '2016-10-05 18:20:00', 2, 1, 70),
(186, 25, 25, '2016-10-12 17:30:00', '2016-10-12 18:20:00', 2, 1, 70),
(187, 25, 25, '2016-10-19 17:30:00', '2016-10-19 18:20:00', 2, 1, 70),
(188, 25, 24, '2016-10-26 17:30:00', '2016-10-26 18:20:00', 2, 1, 70),
(189, 25, 25, '2016-11-02 17:30:00', '2016-11-02 18:20:00', 2, 1, 70),
(190, 25, 25, '2016-11-09 17:30:00', '2016-11-09 18:20:00', 2, 1, 70),
(191, 25, 25, '2016-11-16 17:30:00', '2016-11-16 18:20:00', 2, 1, 70),
(192, 25, 25, '2016-11-23 17:30:00', '2016-11-23 18:20:00', 2, 1, 70),
(193, 25, 25, '2016-11-30 17:30:00', '2016-11-30 18:20:00', 2, 1, 70),
(194, 25, 25, '2016-12-07 17:30:00', '2016-12-07 18:20:00', 2, 1, 70),
(195, 25, 25, '2016-12-14 17:30:00', '2016-12-14 18:20:00', 2, 1, 70),
(196, 25, 25, '2016-12-21 17:30:00', '2016-12-21 18:20:00', 2, 1, 70),
(197, 25, 25, '2016-12-28 17:30:00', '2016-12-28 18:20:00', 2, 1, 70),
(198, 25, 25, '2017-01-04 17:30:00', '2017-01-04 18:20:00', 2, 1, 70),
(199, 25, 25, '2017-01-11 17:30:00', '2017-01-11 18:20:00', 2, 1, 70),
(200, 25, 25, '2017-01-18 17:30:00', '2017-01-18 18:20:00', 2, 1, 70),
(201, 25, 25, '2017-01-25 17:30:00', '2017-01-25 18:20:00', 2, 1, 70),
(202, 25, 25, '2017-02-01 17:30:00', '2017-02-01 18:20:00', 2, 1, 70),
(203, 25, 25, '2017-02-08 17:30:00', '2017-02-08 18:20:00', 2, 1, 70),
(204, 25, 25, '2017-02-15 17:30:00', '2017-02-15 18:20:00', 2, 1, 70),
(205, 25, 25, '2017-02-22 17:30:00', '2017-02-22 18:20:00', 2, 1, 70),
(206, 25, 25, '2017-03-01 17:30:00', '2017-03-01 18:20:00', 2, 1, 70),
(207, 25, 25, '2017-03-08 17:30:00', '2017-03-08 18:20:00', 2, 1, 70),
(208, 25, 25, '2017-03-15 17:30:00', '2017-03-15 18:20:00', 2, 1, 70),
(209, 25, 25, '2017-03-22 17:30:00', '2017-03-22 18:20:00', 2, 1, 70),
(210, 25, 25, '2017-03-29 17:30:00', '2017-03-29 18:20:00', 2, 1, 70),
(211, 25, 25, '2017-04-05 17:30:00', '2017-04-05 18:20:00', 2, 1, 70),
(212, 25, 25, '2017-04-12 17:30:00', '2017-04-12 18:20:00', 2, 1, 70),
(213, 25, 25, '2017-04-19 17:30:00', '2017-04-19 18:20:00', 2, 1, 70),
(214, 25, 25, '2017-04-26 17:30:00', '2017-04-26 18:20:00', 2, 1, 70),
(215, 25, 25, '2017-05-03 17:30:00', '2017-05-03 18:20:00', 2, 1, 70),
(216, 25, 25, '2017-05-10 17:30:00', '2017-05-10 18:20:00', 2, 1, 70),
(217, 25, 25, '2017-05-17 17:30:00', '2017-05-17 18:20:00', 2, 1, 70),
(218, 25, 25, '2017-05-24 17:30:00', '2017-05-24 18:20:00', 2, 1, 70),
(219, 50, 50, '2016-06-01 06:30:00', '2016-06-02 08:00:00', 4, 2, 600),
(220, 50, 50, '2016-06-08 06:30:00', '2016-06-09 08:00:00', 4, 2, 600),
(221, 50, 50, '2016-06-15 06:30:00', '2016-06-16 08:00:00', 4, 2, 600),
(222, 50, 50, '2016-06-22 06:30:00', '2016-06-23 08:00:00', 4, 2, 600),
(223, 50, 50, '2016-06-29 06:30:00', '2016-06-30 08:00:00', 4, 2, 600),
(224, 50, 50, '2016-07-06 06:30:00', '2016-07-07 08:00:00', 4, 2, 600),
(225, 50, 50, '2016-07-13 06:30:00', '2016-07-14 08:00:00', 4, 2, 600),
(226, 50, 50, '2016-07-20 06:30:00', '2016-07-21 08:00:00', 4, 2, 600),
(227, 50, 50, '2016-07-27 06:30:00', '2016-07-28 08:00:00', 4, 2, 600),
(228, 50, 50, '2016-08-03 06:30:00', '2016-08-04 08:00:00', 4, 2, 600),
(229, 50, 50, '2016-08-10 06:30:00', '2016-08-11 08:00:00', 4, 2, 600),
(230, 50, 50, '2016-08-17 06:30:00', '2016-08-18 08:00:00', 4, 2, 600),
(231, 50, 50, '2016-08-24 06:30:00', '2016-08-25 08:00:00', 4, 2, 600),
(232, 50, 50, '2016-08-31 06:30:00', '2016-09-01 08:00:00', 4, 2, 600),
(233, 50, 50, '2016-09-07 06:30:00', '2016-09-08 08:00:00', 4, 2, 600),
(234, 50, 50, '2016-09-14 06:30:00', '2016-09-15 08:00:00', 4, 2, 600),
(235, 50, 50, '2016-09-21 06:30:00', '2016-09-22 08:00:00', 4, 2, 600),
(236, 50, 50, '2016-09-28 06:30:00', '2016-09-29 08:00:00', 4, 2, 600),
(237, 50, 50, '2016-10-05 06:30:00', '2016-10-06 08:00:00', 4, 2, 600),
(238, 50, 50, '2016-10-12 06:30:00', '2016-10-13 08:00:00', 4, 2, 600),
(239, 50, 50, '2016-10-19 06:30:00', '2016-10-20 08:00:00', 4, 2, 600),
(240, 50, 50, '2016-10-26 06:30:00', '2016-10-27 08:00:00', 4, 2, 600),
(241, 50, 50, '2016-11-02 06:30:00', '2016-11-03 08:00:00', 4, 2, 600),
(242, 50, 50, '2016-11-09 06:30:00', '2016-11-10 08:00:00', 4, 2, 600),
(243, 50, 50, '2016-11-16 06:30:00', '2016-11-17 08:00:00', 4, 2, 600),
(244, 50, 50, '2016-11-23 06:30:00', '2016-11-24 08:00:00', 4, 2, 600),
(245, 50, 50, '2016-11-30 06:30:00', '2016-12-01 08:00:00', 4, 2, 600),
(246, 50, 50, '2016-12-07 06:30:00', '2016-12-08 08:00:00', 4, 2, 600),
(247, 50, 50, '2016-12-14 06:30:00', '2016-12-15 08:00:00', 4, 2, 600),
(248, 50, 50, '2016-12-21 06:30:00', '2016-12-22 08:00:00', 4, 2, 600),
(249, 50, 50, '2016-12-28 06:30:00', '2016-12-29 08:00:00', 4, 2, 600),
(250, 50, 49, '2017-01-04 06:30:00', '2017-01-05 08:00:00', 4, 2, 600),
(251, 50, 50, '2017-01-11 06:30:00', '2017-01-12 08:00:00', 4, 2, 600),
(252, 50, 50, '2017-01-18 06:30:00', '2017-01-19 08:00:00', 4, 2, 600),
(253, 50, 50, '2017-01-25 06:30:00', '2017-01-26 08:00:00', 4, 2, 600),
(254, 50, 50, '2017-02-01 06:30:00', '2017-02-02 08:00:00', 4, 2, 600),
(255, 50, 50, '2017-02-08 06:30:00', '2017-02-09 08:00:00', 4, 2, 600),
(256, 50, 50, '2017-02-15 06:30:00', '2017-02-16 08:00:00', 4, 2, 600),
(257, 50, 50, '2017-02-22 06:30:00', '2017-02-23 08:00:00', 4, 2, 600),
(258, 50, 50, '2017-03-01 06:30:00', '2017-03-02 08:00:00', 4, 2, 600),
(259, 50, 50, '2017-03-08 06:30:00', '2017-03-09 08:00:00', 4, 2, 600),
(260, 50, 50, '2017-03-15 06:30:00', '2017-03-16 08:00:00', 4, 2, 600),
(261, 50, 50, '2017-03-22 06:30:00', '2017-03-23 08:00:00', 4, 2, 600),
(262, 50, 50, '2017-03-29 06:30:00', '2017-03-30 08:00:00', 4, 2, 600),
(263, 50, 50, '2017-04-05 06:30:00', '2017-04-06 08:00:00', 4, 2, 600),
(264, 50, 50, '2017-04-12 06:30:00', '2017-04-13 08:00:00', 4, 2, 600),
(265, 50, 50, '2017-04-19 06:30:00', '2017-04-20 08:00:00', 4, 2, 600),
(266, 50, 50, '2017-04-26 06:30:00', '2017-04-27 08:00:00', 4, 2, 600),
(267, 50, 50, '2017-05-03 06:30:00', '2017-05-04 08:00:00', 4, 2, 600),
(268, 50, 50, '2017-05-10 06:30:00', '2017-05-11 08:00:00', 4, 2, 600),
(269, 50, 50, '2017-05-17 06:30:00', '2017-05-18 08:00:00', 4, 2, 600),
(270, 50, 50, '2017-05-24 06:30:00', '2017-05-25 08:00:00', 4, 2, 600),
(271, 50, 50, '2016-06-03 11:00:00', '2016-06-04 13:20:00', 2, 4, 600),
(272, 50, 50, '2016-06-10 11:00:00', '2016-06-11 13:20:00', 2, 4, 600),
(273, 50, 50, '2016-06-17 11:00:00', '2016-06-18 13:20:00', 2, 4, 600),
(274, 50, 50, '2016-06-24 11:00:00', '2016-06-25 13:20:00', 2, 4, 600),
(275, 50, 50, '2016-07-01 11:00:00', '2016-07-02 13:20:00', 2, 4, 600),
(276, 50, 50, '2016-07-08 11:00:00', '2016-07-09 13:20:00', 2, 4, 600),
(277, 50, 50, '2016-07-15 11:00:00', '2016-07-16 13:20:00', 2, 4, 600),
(278, 50, 50, '2016-07-22 11:00:00', '2016-07-23 13:20:00', 2, 4, 600),
(279, 50, 50, '2016-07-29 11:00:00', '2016-07-30 13:20:00', 2, 4, 600),
(280, 50, 50, '2016-08-05 11:00:00', '2016-08-06 13:20:00', 2, 4, 600),
(281, 50, 50, '2016-08-12 11:00:00', '2016-08-13 13:20:00', 2, 4, 600),
(282, 50, 50, '2016-08-19 11:00:00', '2016-08-20 13:20:00', 2, 4, 600),
(283, 50, 50, '2016-08-26 11:00:00', '2016-08-27 13:20:00', 2, 4, 600),
(284, 50, 50, '2016-09-02 11:00:00', '2016-09-03 13:20:00', 2, 4, 600),
(285, 50, 50, '2016-09-09 11:00:00', '2016-09-10 13:20:00', 2, 4, 600),
(286, 50, 50, '2016-09-16 11:00:00', '2016-09-17 13:20:00', 2, 4, 600),
(287, 50, 50, '2016-09-23 11:00:00', '2016-09-24 13:20:00', 2, 4, 600),
(288, 50, 50, '2016-09-30 11:00:00', '2016-10-01 13:20:00', 2, 4, 600),
(289, 50, 50, '2016-10-07 11:00:00', '2016-10-08 13:20:00', 2, 4, 600),
(290, 50, 50, '2016-10-14 11:00:00', '2016-10-15 13:20:00', 2, 4, 600),
(291, 50, 50, '2016-10-21 11:00:00', '2016-10-22 13:20:00', 2, 4, 600),
(292, 50, 50, '2016-10-28 11:00:00', '2016-10-29 13:20:00', 2, 4, 600),
(293, 50, 50, '2016-11-04 11:00:00', '2016-11-05 13:20:00', 2, 4, 600),
(294, 50, 50, '2016-11-11 11:00:00', '2016-11-12 13:20:00', 2, 4, 600),
(295, 50, 50, '2016-11-18 11:00:00', '2016-11-19 13:20:00', 2, 4, 600),
(296, 50, 50, '2016-11-25 11:00:00', '2016-11-26 13:20:00', 2, 4, 600),
(297, 50, 50, '2016-12-02 11:00:00', '2016-12-03 13:20:00', 2, 4, 600),
(298, 50, 50, '2016-12-09 11:00:00', '2016-12-10 13:20:00', 2, 4, 600),
(299, 50, 50, '2016-12-16 11:00:00', '2016-12-17 13:20:00', 2, 4, 600),
(300, 50, 50, '2016-12-23 11:00:00', '2016-12-24 13:20:00', 2, 4, 600),
(301, 50, 50, '2016-12-30 11:00:00', '2016-12-31 13:20:00', 2, 4, 600),
(302, 50, 50, '2017-01-06 11:00:00', '2017-01-07 13:20:00', 2, 4, 600),
(303, 50, 50, '2017-01-13 11:00:00', '2017-01-14 13:20:00', 2, 4, 600),
(304, 50, 50, '2017-01-20 11:00:00', '2017-01-21 13:20:00', 2, 4, 600),
(305, 50, 50, '2017-01-27 11:00:00', '2017-01-28 13:20:00', 2, 4, 600),
(306, 50, 50, '2017-02-03 11:00:00', '2017-02-04 13:20:00', 2, 4, 600),
(307, 50, 50, '2017-02-10 11:00:00', '2017-02-11 13:20:00', 2, 4, 600),
(308, 50, 50, '2017-02-17 11:00:00', '2017-02-18 13:20:00', 2, 4, 600),
(309, 50, 50, '2017-02-24 11:00:00', '2017-02-25 13:20:00', 2, 4, 600),
(310, 50, 50, '2017-03-03 11:00:00', '2017-03-04 13:20:00', 2, 4, 600),
(311, 50, 50, '2017-03-10 11:00:00', '2017-03-11 13:20:00', 2, 4, 600),
(312, 50, 50, '2017-03-17 11:00:00', '2017-03-18 13:20:00', 2, 4, 600),
(313, 50, 50, '2017-03-24 11:00:00', '2017-03-25 13:20:00', 2, 4, 600),
(314, 50, 50, '2017-03-31 11:00:00', '2017-04-01 13:20:00', 2, 4, 600),
(315, 50, 50, '2017-04-07 11:00:00', '2017-04-08 13:20:00', 2, 4, 600),
(316, 50, 50, '2017-04-14 11:00:00', '2017-04-15 13:20:00', 2, 4, 600),
(317, 50, 50, '2017-04-21 11:00:00', '2017-04-22 13:20:00', 2, 4, 600),
(318, 50, 50, '2017-04-28 11:00:00', '2017-04-29 13:20:00', 2, 4, 600),
(319, 50, 50, '2017-05-05 11:00:00', '2017-05-06 13:20:00', 2, 4, 600),
(320, 50, 50, '2017-05-12 11:00:00', '2017-05-13 13:20:00', 2, 4, 600),
(321, 50, 50, '2017-05-19 11:00:00', '2017-05-20 13:20:00', 2, 4, 600),
(322, 50, 50, '2017-05-26 11:00:00', '2017-05-27 13:20:00', 2, 4, 600),
(323, 20, 20, '2016-06-02 06:30:00', '2016-06-03 01:00:00', 5, 4, 350),
(324, 20, 20, '2016-06-02 06:30:00', '2016-06-03 01:00:00', 5, 4, 350),
(325, 20, 20, '2016-06-09 06:30:00', '2016-06-10 01:00:00', 5, 4, 350),
(326, 20, 20, '2016-06-16 06:30:00', '2016-06-17 01:00:00', 5, 4, 350),
(327, 20, 20, '2016-06-23 06:30:00', '2016-06-24 01:00:00', 5, 4, 350),
(328, 20, 20, '2016-06-30 06:30:00', '2016-07-01 01:00:00', 5, 4, 350),
(329, 20, 20, '2016-07-07 06:30:00', '2016-07-08 01:00:00', 5, 4, 350),
(330, 20, 20, '2016-07-14 06:30:00', '2016-07-15 01:00:00', 5, 4, 350),
(331, 20, 20, '2016-07-21 06:30:00', '2016-07-22 01:00:00', 5, 4, 350),
(332, 20, 20, '2016-07-28 06:30:00', '2016-07-29 01:00:00', 5, 4, 350),
(333, 20, 20, '2016-08-04 06:30:00', '2016-08-05 01:00:00', 5, 4, 350),
(334, 20, 20, '2016-08-11 06:30:00', '2016-08-12 01:00:00', 5, 4, 350),
(335, 20, 20, '2016-08-18 06:30:00', '2016-08-19 01:00:00', 5, 4, 350),
(336, 20, 20, '2016-08-25 06:30:00', '2016-08-26 01:00:00', 5, 4, 350),
(337, 20, 20, '2016-09-01 06:30:00', '2016-09-02 01:00:00', 5, 4, 350),
(338, 20, 20, '2016-09-08 06:30:00', '2016-09-09 01:00:00', 5, 4, 350),
(339, 20, 20, '2016-09-15 06:30:00', '2016-09-16 01:00:00', 5, 4, 350),
(340, 20, 20, '2016-09-22 06:30:00', '2016-09-23 01:00:00', 5, 4, 350),
(341, 20, 20, '2016-09-29 06:30:00', '2016-09-30 01:00:00', 5, 4, 350),
(342, 20, 20, '2016-10-06 06:30:00', '2016-10-07 01:00:00', 5, 4, 350),
(343, 20, 20, '2016-10-13 06:30:00', '2016-10-14 01:00:00', 5, 4, 350),
(344, 20, 20, '2016-10-20 06:30:00', '2016-10-21 01:00:00', 5, 4, 350),
(345, 20, 20, '2016-10-27 06:30:00', '2016-10-28 01:00:00', 5, 4, 350),
(346, 20, 20, '2016-11-03 06:30:00', '2016-11-04 01:00:00', 5, 4, 350),
(347, 20, 20, '2016-11-10 06:30:00', '2016-11-11 01:00:00', 5, 4, 350),
(348, 20, 20, '2016-11-17 06:30:00', '2016-11-18 01:00:00', 5, 4, 350),
(349, 20, 20, '2016-11-24 06:30:00', '2016-11-25 01:00:00', 5, 4, 350),
(350, 20, 20, '2016-12-01 06:30:00', '2016-12-02 01:00:00', 5, 4, 350),
(351, 20, 20, '2016-12-08 06:30:00', '2016-12-09 01:00:00', 5, 4, 350),
(352, 20, 20, '2016-12-15 06:30:00', '2016-12-16 01:00:00', 5, 4, 350),
(353, 20, 20, '2016-12-22 06:30:00', '2016-12-23 01:00:00', 5, 4, 350),
(354, 20, 20, '2016-12-29 06:30:00', '2016-12-30 01:00:00', 5, 4, 350),
(355, 20, 20, '2017-01-05 06:30:00', '2017-01-06 01:00:00', 5, 4, 350),
(356, 20, 20, '2017-01-12 06:30:00', '2017-01-13 01:00:00', 5, 4, 350),
(357, 20, 20, '2017-01-19 06:30:00', '2017-01-20 01:00:00', 5, 4, 350),
(358, 20, 20, '2017-01-26 06:30:00', '2017-01-27 01:00:00', 5, 4, 350),
(359, 20, 20, '2017-02-02 06:30:00', '2017-02-03 01:00:00', 5, 4, 350),
(360, 20, 20, '2017-02-09 06:30:00', '2017-02-10 01:00:00', 5, 4, 350),
(361, 20, 20, '2017-02-16 06:30:00', '2017-02-17 01:00:00', 5, 4, 350),
(362, 20, 20, '2017-02-23 06:30:00', '2017-02-24 01:00:00', 5, 4, 350),
(363, 20, 20, '2017-03-02 06:30:00', '2017-03-03 01:00:00', 5, 4, 350),
(364, 20, 20, '2017-03-09 06:30:00', '2017-03-10 01:00:00', 5, 4, 350),
(365, 20, 20, '2017-03-16 06:30:00', '2017-03-17 01:00:00', 5, 4, 350),
(366, 20, 20, '2017-03-23 06:30:00', '2017-03-24 01:00:00', 5, 4, 350),
(367, 20, 20, '2017-03-30 06:30:00', '2017-03-31 01:00:00', 5, 4, 350),
(368, 20, 20, '2017-04-06 06:30:00', '2017-04-07 01:00:00', 5, 4, 350),
(369, 20, 20, '2017-04-13 06:30:00', '2017-04-14 01:00:00', 5, 4, 350),
(370, 20, 20, '2017-04-20 06:30:00', '2017-04-21 01:00:00', 5, 4, 350),
(371, 20, 20, '2017-04-27 06:30:00', '2017-04-28 01:00:00', 5, 4, 350),
(372, 20, 20, '2017-05-04 06:30:00', '2017-05-05 01:00:00', 5, 4, 350),
(373, 20, 20, '2017-05-11 06:30:00', '2017-05-12 01:00:00', 5, 4, 350),
(374, 20, 20, '2017-05-18 06:30:00', '2017-05-19 01:00:00', 5, 4, 350),
(375, 20, 20, '2017-05-25 06:30:00', '2017-05-26 01:00:00', 5, 4, 350),
(376, 20, 20, '2016-05-29 13:00:00', '2016-05-30 06:00:00', 4, 5, 350),
(377, 20, 20, '2016-06-05 13:00:00', '2016-06-06 06:00:00', 4, 5, 350),
(378, 20, 20, '2016-06-12 13:00:00', '2016-06-13 06:00:00', 4, 5, 350),
(379, 20, 20, '2016-06-19 13:00:00', '2016-06-20 06:00:00', 4, 5, 350),
(380, 20, 20, '2016-06-26 13:00:00', '2016-06-27 06:00:00', 4, 5, 350),
(381, 20, 20, '2016-07-03 13:00:00', '2016-07-04 06:00:00', 4, 5, 350),
(382, 20, 20, '2016-07-10 13:00:00', '2016-07-11 06:00:00', 4, 5, 350),
(383, 20, 20, '2016-07-17 13:00:00', '2016-07-18 06:00:00', 4, 5, 350),
(384, 20, 20, '2016-07-24 13:00:00', '2016-07-25 06:00:00', 4, 5, 350),
(385, 20, 20, '2016-07-31 13:00:00', '2016-08-01 06:00:00', 4, 5, 350),
(386, 20, 20, '2016-08-07 13:00:00', '2016-08-08 06:00:00', 4, 5, 350),
(387, 20, 20, '2016-08-14 13:00:00', '2016-08-15 06:00:00', 4, 5, 350),
(388, 20, 20, '2016-08-21 13:00:00', '2016-08-22 06:00:00', 4, 5, 350),
(389, 20, 20, '2016-08-28 13:00:00', '2016-08-29 06:00:00', 4, 5, 350),
(390, 20, 20, '2016-09-04 13:00:00', '2016-09-05 06:00:00', 4, 5, 350),
(391, 20, 20, '2016-09-11 13:00:00', '2016-09-12 06:00:00', 4, 5, 350),
(392, 20, 20, '2016-09-18 13:00:00', '2016-09-19 06:00:00', 4, 5, 350),
(393, 20, 20, '2016-09-25 13:00:00', '2016-09-26 06:00:00', 4, 5, 350),
(394, 20, 20, '2016-10-02 13:00:00', '2016-10-03 06:00:00', 4, 5, 350),
(395, 20, 20, '2016-10-09 13:00:00', '2016-10-10 06:00:00', 4, 5, 350),
(396, 20, 20, '2016-10-16 13:00:00', '2016-10-17 06:00:00', 4, 5, 350),
(397, 20, 20, '2016-10-23 13:00:00', '2016-10-24 06:00:00', 4, 5, 350),
(398, 20, 20, '2016-10-30 13:00:00', '2016-10-31 06:00:00', 4, 5, 350),
(399, 20, 20, '2016-11-06 13:00:00', '2016-11-07 06:00:00', 4, 5, 350),
(400, 20, 20, '2016-11-13 13:00:00', '2016-11-14 06:00:00', 4, 5, 350),
(401, 20, 20, '2016-11-20 13:00:00', '2016-11-21 06:00:00', 4, 5, 350),
(402, 20, 20, '2016-11-27 13:00:00', '2016-11-28 06:00:00', 4, 5, 350),
(403, 20, 20, '2016-12-04 13:00:00', '2016-12-05 06:00:00', 4, 5, 350),
(404, 20, 20, '2016-12-11 13:00:00', '2016-12-12 06:00:00', 4, 5, 350),
(405, 20, 20, '2016-12-18 13:00:00', '2016-12-19 06:00:00', 4, 5, 350),
(406, 20, 20, '2016-12-25 13:00:00', '2016-12-26 06:00:00', 4, 5, 350),
(407, 20, 19, '2017-01-01 13:00:00', '2017-01-02 06:00:00', 4, 5, 350),
(408, 20, 20, '2017-01-08 13:00:00', '2017-01-09 06:00:00', 4, 5, 350),
(409, 20, 20, '2017-01-15 13:00:00', '2017-01-16 06:00:00', 4, 5, 350),
(410, 20, 20, '2017-01-22 13:00:00', '2017-01-23 06:00:00', 4, 5, 350),
(411, 20, 20, '2017-01-29 13:00:00', '2017-01-30 06:00:00', 4, 5, 350),
(412, 20, 20, '2017-02-05 13:00:00', '2017-02-06 06:00:00', 4, 5, 350),
(413, 20, 20, '2017-02-12 13:00:00', '2017-02-13 06:00:00', 4, 5, 350),
(414, 20, 20, '2017-02-19 13:00:00', '2017-02-20 06:00:00', 4, 5, 350),
(415, 20, 20, '2017-02-26 13:00:00', '2017-02-27 06:00:00', 4, 5, 350),
(416, 20, 20, '2017-03-05 13:00:00', '2017-03-06 06:00:00', 4, 5, 350),
(417, 20, 20, '2017-03-12 13:00:00', '2017-03-13 06:00:00', 4, 5, 350),
(418, 20, 20, '2017-03-19 13:00:00', '2017-03-20 06:00:00', 4, 5, 350),
(419, 20, 20, '2017-03-26 13:00:00', '2017-03-27 06:00:00', 4, 5, 350),
(420, 20, 20, '2017-04-02 13:00:00', '2017-04-03 06:00:00', 4, 5, 350),
(421, 20, 20, '2017-04-09 13:00:00', '2017-04-10 06:00:00', 4, 5, 350),
(422, 20, 20, '2017-04-16 13:00:00', '2017-04-17 06:00:00', 4, 5, 350),
(423, 20, 20, '2017-04-23 13:00:00', '2017-04-24 06:00:00', 4, 5, 350),
(424, 20, 20, '2017-04-30 13:00:00', '2017-05-01 06:00:00', 4, 5, 350),
(425, 20, 20, '2017-05-07 13:00:00', '2017-05-08 06:00:00', 4, 5, 350),
(426, 20, 20, '2017-05-14 13:00:00', '2017-05-15 06:00:00', 4, 5, 350),
(427, 20, 20, '2017-05-21 13:00:00', '2017-05-22 06:00:00', 4, 5, 350);

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
(3, 'Domsten', 'Svenska', 'SEK', 'Sverige', 'GMT +1'),
(4, 'Rom', 'Italienska', 'Euro', 'Italien', 'GMT +2'),
(5, 'Berlin', 'Tyska', 'Euro', 'Tyskland', 'GMT +1');

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
('Joel', 'Nilsson', '9210283793', 'Amiralsgatan 84B', 'joel@joel.com', 6, '0761178885'),
('Pelle', 'Svensson', '990503-1563', 'Svängkullen 123', 'pelle_coolboy99@hotmail.se', 10, '0733-121388');

-- --------------------------------------------------------

--
-- Tabellstruktur `ticket`
--

CREATE TABLE `ticket` (
  `ticketID` int(11) NOT NULL,
  `ticketCustomerID` int(11) NOT NULL,
  `type` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumpning av Data i tabell `ticket`
--

INSERT INTO `ticket` (`ticketID`, `ticketCustomerID`, `type`) VALUES
(33, 10, 'Enkel'),
(34, 10, 'Enkel'),
(35, 6, 'Enkel');

-- --------------------------------------------------------

--
-- Tabellstruktur `validity`
--

CREATE TABLE `validity` (
  `ticketID` int(11) NOT NULL,
  `tripID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumpning av Data i tabell `validity`
--

INSERT INTO `validity` (`ticketID`, `tripID`) VALUES
(33, 250),
(34, 407),
(35, 188);

--
-- Index för dumpade tabeller
--

--
-- Index för tabell `bustrip`
--
ALTER TABLE `bustrip`
  ADD PRIMARY KEY (`tripID`),
  ADD KEY `origin` (`origin`),
  ADD KEY `destination` (`destination`),
  ADD KEY `trip-ID` (`tripID`);

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
  ADD PRIMARY KEY (`ticketID`),
  ADD KEY `ticketCustomerID` (`ticketCustomerID`);

--
-- Index för tabell `validity`
--
ALTER TABLE `validity`
  ADD PRIMARY KEY (`ticketID`,`tripID`),
  ADD KEY `ticket-ID` (`ticketID`),
  ADD KEY `trip-ID` (`tripID`);

--
-- AUTO_INCREMENT för dumpade tabeller
--

--
-- AUTO_INCREMENT för tabell `bustrip`
--
ALTER TABLE `bustrip`
  MODIFY `tripID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=428;
--
-- AUTO_INCREMENT för tabell `city`
--
ALTER TABLE `city`
  MODIFY `cityID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT för tabell `customer`
--
ALTER TABLE `customer`
  MODIFY `customerID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
--
-- AUTO_INCREMENT för tabell `ticket`
--
ALTER TABLE `ticket`
  MODIFY `ticketID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=36;
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
-- Restriktioner för tabell `ticket`
--
ALTER TABLE `ticket`
  ADD CONSTRAINT `ticketCustomerIDFK` FOREIGN KEY (`ticketCustomerID`) REFERENCES `customer` (`customerID`);

--
-- Restriktioner för tabell `validity`
--
ALTER TABLE `validity`
  ADD CONSTRAINT `ticketIDFK` FOREIGN KEY (`ticketID`) REFERENCES `ticket` (`ticketID`),
  ADD CONSTRAINT `validtripFK` FOREIGN KEY (`tripID`) REFERENCES `bustrip` (`tripID`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
