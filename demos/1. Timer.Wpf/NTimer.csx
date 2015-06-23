﻿using System;
using System.Threading;

#if NETFX_CORE
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
#else
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
#endif

using NReact;

public partial class NTimer : NComponent
{
  Timer _timer;

  public override void ComponentDidMount()
  {
    _timer = new Timer(UpdateTime, null, 0, 100);  
  }

  public override void ComponentWillUnmount()
  {
    _timer.Dispose();
  }

  protected override object GetInitialState()
  {
    return new { Start = DateTime.Now, Now = DateTime.Now };
  }

  void UpdateTime(object state)
  {
    SetState(new { Now = DateTime.Now });
  }

  public override object Render()
  {
    return 
      <TextBlock Text={ (State.Now - State.Start).ToString("s'.'f") } HorizontalAlignment="Center" VerticalAlignment="Center" FontSize={24.5}/>;
  }
}
