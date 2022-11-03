import java.awt.*; 
import java.applet.*;
/* <applet code="MovingBall.class" height=300 width=300></applet> */ 
public class MovingBall extends Applet implements Runnable
{
int x,y,dx,dy,w,h; 
Thread t;
boolean flag; 
public void init()
{
w=getWidth(); 
h=getHeight();
setBackground(Color.yellow); 
x=100;
y=10;
dx=10; 
dy=10;
}
public void start()
{
flag=true;
t=new Thread(this); 
t.start();
}
public void paint(Graphics g)
{
g.setColor(Color.blue); 
g.fillOval(x,y,50,50);

}
public void run()
{
while(flag)
{

if((x+dx<=0)||(x+dx>=w))
 dx=-dx;
if((y+dy<=0)||(y+dy>=h)) 
dy=-dy;
x+=dx;
 y+=dy; 
repaint(); 
try
{
Thread.sleep(300);
}
catch(InterruptedException e)
{}
}
}
public void stop()
{
	t=null; 
	flag=false;
}
