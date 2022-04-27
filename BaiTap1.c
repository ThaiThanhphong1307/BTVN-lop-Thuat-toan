#include<stdio.h>
#include<string.h>
int main(){
	int id[] = {1, 2, 3, 4, 5};
	char ten[][20] = {"Hung", "Hien", "Phuong", "Tung", "Duc"};
	char csharp[][20] = {"true", "false", "true", "false", "false"};
	char java[][20] = {"false", "true", "false", "true", "false"};
	
	//in thong tin
	printf("\n%d %s %s %s", id[0], ten[0], csharp[0], java[0]);
	printf("\n%d %s %s %s", id[1], ten[1], csharp[1], java[1]);
	printf("\n%d %s %s %s", id[2], ten[2], csharp[2], java[2]);
	printf("\n%d %s %s %s", id[3], ten[3], csharp[3], java[3]);
	printf("\n%d %s %s %s", id[4], ten[4], csharp[4], java[4]);
	
	//liet ke sv yeu thich csharp
	printf("\ncac sing vien yeu thich mon csharp:");
	int a;
	for(a=0; a<5; a++)
	{
		if(strlen(csharp[a]) == 4)
		{
			printf("\n%d %s %s", id[a], ten[a], csharp[a]);
		}
	}
	
	//liet ke sv yeu thich java
	printf("\ncac sing vien yeu thich mon java:");
	int b;
	for(b=0; b<5; b++)
	{
		if(strlen(java[b]) == 4)
		{
			printf("\n%d %s %s", id[b], ten[b], java[b]);
		}
	}
	return 0;
}
