import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UrlTargetComponent } from './url-target.component';

describe('UrlTargetComponent', () => {
  let component: UrlTargetComponent;
  let fixture: ComponentFixture<UrlTargetComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UrlTargetComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(UrlTargetComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
