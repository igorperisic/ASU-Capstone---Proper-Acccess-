import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { NetworkRecommendationComponent } from './network-recommendation.component';

describe('NetworkRecommendationComponent', () => {
  let component: NetworkRecommendationComponent;
  let fixture: ComponentFixture<NetworkRecommendationComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ NetworkRecommendationComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(NetworkRecommendationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
