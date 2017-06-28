CREATE TABLE `city_building_barracks` (
  `actorid` int(11) NOT NULL DEFAULT '0' COMMENT '',
  `offset` tinyint(3) NOT NULL DEFAULT '0' COMMENT '',
  `kind` tinyint(3) NOT NULL DEFAULT '0' COMMENT '兵营种类',
  `level` tinyint(3) NOT NULL DEFAULT '0' COMMENT '兵营等级',
  `soldiers` int(11) NOT NULL DEFAULT '0' COMMENT '本营兵力',
  `trainnum` int(11) NOT NULL DEFAULT '0' COMMENT '当前训练士兵数',
  `trainsec` int(11) NOT NULL DEFAULT '0' COMMENT '当前训练剩余时间(秒)',
  `queuenum0` int(11) NOT NULL DEFAULT '0' COMMENT '招募队列',
  `queuenum1` int(11) NOT NULL DEFAULT '0' COMMENT '招募队列',
  `queuenum2` int(11) NOT NULL DEFAULT '0' COMMENT '招募队列',
  `queuenum3` int(11) NOT NULL DEFAULT '0' COMMENT '招募队列',
  `queuenum4` int(11) NOT NULL DEFAULT '0' COMMENT '招募队列',
  `queuenum5` int(11) NOT NULL DEFAULT '0' COMMENT '招募队列',
  `queuenum6` int(11) NOT NULL DEFAULT '0' COMMENT '招募队列',
  `queuenum7` int(11) NOT NULL DEFAULT '0' COMMENT '招募队列',
  `queuesec0` int(11) NOT NULL DEFAULT '0' COMMENT '招募队列',
  `queuesec1` int(11) NOT NULL DEFAULT '0' COMMENT '招募队列',
  `queuesec2` int(11) NOT NULL DEFAULT '0' COMMENT '招募队列',
  `queuesec3` int(11) NOT NULL DEFAULT '0' COMMENT '招募队列',
  `queuesec4` int(11) NOT NULL DEFAULT '0' COMMENT '招募队列',
  `queuesec5` int(11) NOT NULL DEFAULT '0' COMMENT '招募队列',
  `queuesec6` int(11) NOT NULL DEFAULT '0' COMMENT '招募队列',
  `queuesec7` int(11) NOT NULL DEFAULT '0' COMMENT '招募队列',
  `queue` tinyint(3) NOT NULL DEFAULT '0' COMMENT '扩容队列数量',
  `trainlong` tinyint(3) NOT NULL DEFAULT '0' COMMENT '募兵加时级别',
  `quicksec` smallint(6) NOT NULL DEFAULT '0' COMMENT '募兵加速时间秒',
  PRIMARY KEY (`actorid`)
  KEY (`offset`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
