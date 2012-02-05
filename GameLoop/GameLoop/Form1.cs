using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tao.OpenGl;

namespace GameLoop
{
    public partial class Form1 : Form
    {
        FastLoop _fastLoop;
        bool _fullScreen = false;

        StateSystem _stateSystem = new StateSystem();

        public Form1()
        {
            // Add all the states that will be used
            _stateSystem.AddState("splash", new SplashScreenState(_stateSystem));
            _fastLoop = new FastLoop(GameLoop);
            InitializeComponent();
            _openGLControl.InitializeContexts();
            if (_fullScreen)
            {
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
            }
        }

        void GameLoop(double elapsedTime)
        {
            Gl.glClearColor(0.0f, 0.0f, 0.0f, 1.0f);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            Gl.glPointSize(5.0f);
            Gl.glRotated(10 * elapsedTime, 0, 1, 0);
            Gl.glBegin(Gl.GL_TRIANGLES);
            {
                Gl.glColor3d(1.0f, 0.0f, 0.0f);
                Gl.glVertex3d(-0.5, -0.25, 0);
                Gl.glColor3d(0.0f, 1.0f, 0.0f);
                Gl.glVertex3d(0.5, -0.25, 0);
                Gl.glColor3d(0.0f, 0.0f, 1.0f);
                Gl.glVertex3d(0, 0.75, 0);
            }
            Gl.glEnd();
            Gl.glFinish();
            _openGLControl.Refresh();
        }

    }
}
