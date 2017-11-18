#ifndef __KINGWARTOWN_AUTO_H
#define __KINGWARTOWN_AUTO_H
#include "define.h"

struct _kingwar_town {
//--Automatically generated
				int id;	//id
				char nation;	//ռ���
				int attack_total;	//�������ܱ���
				int defense_total;	//�������ܱ���
				int sec;	//ս������ʱ
				int attack_queue[2048];	//��������
				int defense_queue[2048];	//���ض���
};
typedef struct _kingwar_town KingwarTown;

typedef KingwarTown * (*LPCB_GETKINGWARTOWN)( int id );
typedef int (*LPCB_LOADKINGWARTOWN)( int id );
int kingwar_town_load_auto( LPCB_GETKINGWARTOWN pCB_GetKingwarTown, LPCB_LOADKINGWARTOWN pCB_LoadKingwarTown, const char *pTab );
int kingwar_town_save_auto( KingwarTown *pKingwarTown, const char *pTab, FILE *fp );
int kingwar_town_batch_save_auto( KingwarTown *pKingwarTown, int maxcount,  const char *pTab, FILE *fp );

#endif