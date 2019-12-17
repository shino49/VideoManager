--create database video_manager;
use  video_manager;

create table appuser(
	userid int not null identity(1,1) primary key,
	username varchar(40) unique not null,
	passwd char(32),
	claims varchar(5) not null
		check(claims in ('admin','user','guest')),
	avator image
);

insert into appuser (username,passwd,claims)
	values('admin','89088DC0047CF877395138C3D9041CA0','admin');





create table movie (
    douban_id varchar(16) not null,
    title varchar(1024),
    directors text,
    scriptwriters text,
    actors text,
    vi_types text,
    release_region text,
    release_date text,
    alias text,
    languages text,
    duration text,
    score text,
    description text,
    tags text,
    primary key(douban_id)
);

create table photo (
    id int not null identity(1,1),
    douban_id varchar(16),
    type tinyint,
    photo_id varchar(16),
    primary key(id)
);

create table comment(
	commentid int not null identity(1,1) primary key,
	userid int not null foreign key references appuser,
	douban_id varchar(16) not null foreign key references movie,
	content text
		check(count(content) <= 140),
	pubtime timestamp
);

create table barrage(
	barrageid int not null identity(1,1) primary key,
	userid int not null foreign key references appuser,
	douban_id varchar(16) not null foreign key references movie,
	sec int
		check(sec > 0 and sec < 36000),
)