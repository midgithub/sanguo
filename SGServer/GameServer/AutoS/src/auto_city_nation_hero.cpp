#ifdef WIN32
#include <winsock2.h>
#include <windows.h>
#endif
#include <mysql.h>
#include "db.h"
#include "actor.h"
#include "auto_city_nation_hero.h"
extern MYSQL *myGame;
extern char g_batchsql[BATCHSQL_MAXSIZE];

int city_nation_hero_load_auto( int actorid, int city_index, LPCB_GETCITYNATIONHERO pCB_GetCityNationHero, const char *pTab )
{
	MYSQL_RES	*res;
	MYSQL_ROW	row;
	char	szSQL[8192] = {0};
	int offset = 0;
	CityNationHero *pCityNationHero;

	sprintf( szSQL, "select `actorid`,`offset`,`state`,`kind`,`forever`,`loyal`,`buypos` from %s where actorid='%d'", pTab, actorid );
	if( mysql_query( myGame, szSQL ) )
	{
		printf( "Query failed (%s)\n", mysql_error(myGame) );
		write_gamelog( "%s", szSQL );
		if( mysql_ping(myGame) != 0 )
			db_reconnect_game();
		return -1;
	}
	res = mysql_store_result( myGame );

	while( ( row = mysql_fetch_row( res ) ) )
	{
		offset = 0;
		pCityNationHero = pCB_GetCityNationHero( city_index, atoi(row[1]) );
		if( pCityNationHero == NULL )
			continue;
		offset++;
		offset++;
		pCityNationHero->state = atoi(row[offset++]);
		pCityNationHero->kind = atoi(row[offset++]);
		pCityNationHero->forever = atoi(row[offset++]);
		pCityNationHero->loyal = atoi(row[offset++]);
		pCityNationHero->buypos = atoi(row[offset++]);
	}
	mysql_free_result( res );
	return 0;
}
int city_nation_hero_save_auto( int actorid, int offset, CityNationHero *pCityNationHero, const char *pTab, FILE *fp )
{
	char	szSQL[8192] = {0};
	char reconnect_flag = 0;
	if ( pCityNationHero == NULL )
		return -1;

RE_CITYNATIONHERO_UPDATE:
	sprintf( szSQL, "REPLACE INTO %s (`actorid`,`offset`,`state`,`kind`,`forever`,`loyal`,`buypos`) Values('%d','%d','%d','%d','%d','%d','%d')",pTab,actorid,offset,pCityNationHero->state,pCityNationHero->kind,pCityNationHero->forever,pCityNationHero->loyal,pCityNationHero->buypos);
	if( fp )
	{
		fprintf( fp, "%s;\n", szSQL );
	}
	else if( mysql_query( myGame, szSQL ) )
	{
		printf( "Query failed (%s)\n", mysql_error(myGame) );
		write_gamelog( "%s", szSQL );
		if( reconnect_flag )
			return -1;
		if( mysql_ping(myGame) != 0 )
		{
			db_reconnect_game();
			reconnect_flag = 1;
			goto RE_CITYNATIONHERO_UPDATE;
		}
		return -1;
	}
	return 0;
}

int city_nation_hero_batch_save_auto( int actorid, CityNationHero *pCityNationHero, int maxcount, const char *pTab, FILE *fp )
{
	char	szSQL[8192] = {0};
	if ( pCityNationHero == NULL )
		return -1;

	int count = 0;
	memset( g_batchsql, 0, sizeof(char)*BATCHSQL_MAXSIZE );
	for ( int index = 0; index < maxcount; index++ )
	{
		if ( pCityNationHero[index].kind <= 0 )
			continue;
		if ( count == 0 )
		{
			sprintf( g_batchsql, "REPLACE INTO %s (`actorid`,`offset`,`state`,`kind`,`forever`,`loyal`,`buypos`) Values('%d','%d','%d','%d','%d','%d','%d')",pTab,actorid,index,pCityNationHero[index].state,pCityNationHero[index].kind,pCityNationHero[index].forever,pCityNationHero[index].loyal,pCityNationHero[index].buypos);
		}
		else
		{
			sprintf( szSQL, ",('%d','%d','%d','%d','%d','%d','%d')",actorid,index,pCityNationHero[index].state,pCityNationHero[index].kind,pCityNationHero[index].forever,pCityNationHero[index].loyal,pCityNationHero[index].buypos);
			strcat( g_batchsql, szSQL );
		}
		count += 1;
		if ( count > 15 )
		{
			count = 0;
			db_query( fp, g_batchsql );
			memset( g_batchsql, 0, sizeof(char)*BATCHSQL_MAXSIZE );
		}
	}
	if ( count > 0 )
	{
		count = 0;
		db_query( fp, g_batchsql );
		memset( g_batchsql, 0, sizeof(char)*BATCHSQL_MAXSIZE );
	}
	return 0;
}
