import { Component, AfterViewInit, ElementRef, ViewChild } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { gsap } from 'gsap';

@Component({
  selector: 'app-desk',
  standalone: true,
  imports: [CommonModule, RouterModule],
  templateUrl: './desk.component.html',
  styleUrl: './desk.component.sass'
})
export class DeskComponent implements AfterViewInit {
  @ViewChild('desk', { static: true }) desk!: ElementRef;
  @ViewChild('monitor', { static: true }) monitor!: ElementRef;

  ngAfterViewInit(): void {
    const deskEl = this.desk.nativeElement;
    const monitorEl = this.monitor.nativeElement;

    const timeline = gsap.timeline();
    timeline.to(deskEl, { scale: 1.5, duration: 2, ease: 'power2.inOut' })
            .to(monitorEl, { scale: 2, duration: 2, ease: 'power2.inOut' });
  }
}