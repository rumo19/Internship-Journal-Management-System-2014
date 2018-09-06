#include<stdio.h>
main()
{
int a,b[100],v,d,i,j,k,m;
for(i=0;i<=4;i++)
{
    scanf("%d",&b[i]);

}

for(i=0;i<=4;i++)
{
	m=0;
	printf("a\n");

    for(j=0;j<4;j++)
    {
        if(b[j]>=b[j+1])
        {

            v=b[j];
            b[j]=b[j+1];

            b[j+1]=v;

		}
		else
			m++;
    if(m>=3)
		break;

        for(k=0;k<=4;k++)
            {
                printf("%d ",b[k]);
            }
            printf("\n");
    }
	if(m>=3)
		break;


}
for(i=0;i<=4;i++)
    printf("%d\n",b[i]);
}
