CREATE TABLE `city` (
  `actorid` int(11) NOT NULL DEFAULT '0' COMMENT '角色ID',
  `index` int(11) NOT NULL DEFAULT '0' COMMENT '索引',
  `name` varbinary(22) NOT NULL DEFAULT '' COMMENT '名称',
  `type` tinyint(3) NOT NULL DEFAULT '0' COMMENT '城池类型',
  `shape` tinyint(3) NOT NULL DEFAULT '0' COMMENT '领主形象(选取)',
  `headid` int(11) NOT NULL DEFAULT '0' COMMENT '领主头像(自定义)',
  `country` smallint(6) NOT NULL DEFAULT '0' COMMENT '选择的国家(真实)',
  `ipcountry` varbinary(3) NOT NULL DEFAULT '' COMMENT 'IP地址所在国家',
  `language` tinyint(3) NOT NULL DEFAULT '0' COMMENT '选择语言',
  `os` tinyint(3) NOT NULL DEFAULT '0' COMMENT '系统1ios 2android 3win',
  `platid` tinyint(3) NOT NULL DEFAULT '0' COMMENT '平台',
  `createtime` int(11) NOT NULL DEFAULT '0' COMMENT '创建时间',
  `lastlogin` int(11) NOT NULL DEFAULT '0' COMMENT '上次登陆时间',
  `lastlogout` int(11) NOT NULL DEFAULT '0' COMMENT '上次登出时间',
  `state` tinyint(3) NOT NULL DEFAULT '0' COMMENT '城池当前状态',
  `posx` smallint(6) NOT NULL DEFAULT '0' COMMENT '位置',
  `posy` smallint(6) NOT NULL DEFAULT '0' COMMENT '位置',
  `sflag` int(11) NOT NULL DEFAULT '0' COMMENT '标志位',
  `level` smallint(6) NOT NULL DEFAULT '0' COMMENT '玩家等级',
  `exp` int(11) NOT NULL DEFAULT '0' COMMENT '玩家经验',
  `vipexp` int(11) NOT NULL DEFAULT '0' COMMENT 'VIP经验',
  `nation` tinyint(3) NOT NULL DEFAULT '0' COMMENT '国家(魏蜀吴)',
  `official` tinyint(3) NOT NULL DEFAULT '0' COMMENT '官职',
  `place` tinyint(3) NOT NULL DEFAULT '0' COMMENT '爵位',
  `zone` tinyint(3) NOT NULL DEFAULT '0' COMMENT '区域',
  `battlepower` int(11) NOT NULL DEFAULT '0' COMMENT '战力',
  `mokilllv` tinyint(3) NOT NULL DEFAULT '0' COMMENT '击杀野怪最高级别',
  `body` smallint(6) NOT NULL DEFAULT '0' COMMENT '体力',
  `bodysec` smallint(6) NOT NULL DEFAULT '0' COMMENT '体力恢复时间(每秒-1)',
  `silver` int(11) NOT NULL DEFAULT '0' COMMENT '银币',
  `wood` int(11) NOT NULL DEFAULT '0' COMMENT '木材',
  `food` int(11) NOT NULL DEFAULT '0' COMMENT '粮草',
  `iron` int(11) NOT NULL DEFAULT '0' COMMENT '镔铁',
  `levynum` tinyint(3) NOT NULL DEFAULT '0' COMMENT '当前征收次数',
  `levysec` smallint(6) NOT NULL DEFAULT '0' COMMENT '下次征收时间(每秒-1)',
  `people` int(11) NOT NULL DEFAULT '0' COMMENT '人口',
  `prestige` int(11) NOT NULL DEFAULT '0' COMMENT '威望值',
  `friendship` int(11) NOT NULL DEFAULT '0' COMMENT '友谊积分',
  `function` int(11) NOT NULL DEFAULT '0' COMMENT '功能是否开启',
  `worker_op` tinyint(3) NOT NULL DEFAULT '0' COMMENT '建造队列操作',
  `worker_sec` int(11) NOT NULL DEFAULT '0' COMMENT '建造剩余时间(每秒-1)',
  `worker_kind` tinyint(3) NOT NULL DEFAULT '0' COMMENT '当前升级建筑类型',
  `worker_offset` tinyint(3) NOT NULL DEFAULT '0' COMMENT '当前升级建筑索引',
  `worker_op_ex` tinyint(3) NOT NULL DEFAULT '0' COMMENT '建造队列操作(商用)',
  `worker_sec_ex` int(11) NOT NULL DEFAULT '0' COMMENT '建造剩余时间(每秒-1)(商用)',
  `worker_kind_ex` tinyint(3) NOT NULL DEFAULT '0' COMMENT '当前升级建筑类型(商用)',
  `worker_offset_ex` tinyint(3) NOT NULL DEFAULT '0' COMMENT '当前升级建筑索引(商用)',
  `worker_expire_ex` int(11) NOT NULL DEFAULT '0' COMMENT '商用建造队列到期时间',
  PRIMARY KEY (`actorid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
